﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataTool.DataModels;
using DataTool.Flag;
using OWLib;
using STULib.Types;
using STULib.Types.Generic;
using static DataTool.Helper.STUHelper;
using static DataTool.Helper.IO;
using static DataTool.Helper.Logger;

namespace DataTool.SaveLogic.Unlock {
    public class Skin {
        public static void Save(ICLIFlags flags, string skinName, string basePath, STUHero hero, string rarity, STUSkinOverride skinOverride, List<ItemInfo> weaponSkins, List<STULoadout> abilities, bool quiet = true) {
            string heroName = GetString(hero.Name);
            string heroNamePath = GetValidFilename(heroName) ?? "Unknown";
            heroNamePath = heroNamePath.TrimEnd(' ');
            
            string path = Path.Combine(basePath,
                $"{heroNamePath}\\Skins\\{rarity}\\{GetValidFilename(skinName)}");
            
            Dictionary<uint, ItemInfo> realWeaponSkins = new Dictionary<uint, ItemInfo>();
            if (weaponSkins != null) {
                foreach (ItemInfo weaponSkin in weaponSkins) {
                    realWeaponSkins[((STUUnlock_Weapon) weaponSkin.Unlock).Index] = weaponSkin;
                }
            }
            
            Dictionary<ulong, ulong> replacements = skinOverride.ProperReplacements;
            
            LoudLog("\tFinding");
            FindLogic.Combo.ComboInfo info = new FindLogic.Combo.ComboInfo();
            FindLogic.Combo.Find(info, hero.EntityMain, replacements);
            FindLogic.Combo.Find(info, hero.EntityHeroSelect, replacements);
            FindLogic.Combo.Find(info, hero.EntityHighlightIntro, replacements);
            FindLogic.Combo.Find(info, hero.EntityPlayable, replacements);
            FindLogic.Combo.Find(info, hero.EntityThirdPerson, replacements);

            info.Config.DoExistingEntities = true;
            
            uint replacementIndex = 0;
            foreach (Common.STUGUID weaponOverrideGUID in skinOverride.Weapons) {
                STUHeroWeapon weaponOverride = GetInstance<STUHeroWeapon>(weaponOverrideGUID);
                if (weaponOverride == null) continue;

                string weaponSkinName = null;
                if (realWeaponSkins.ContainsKey(replacementIndex)) {
                    weaponSkinName = GetValidFilename(GetString(realWeaponSkins[replacementIndex].Unlock.CosmeticName));
                }

                Dictionary<ulong, ulong> weaponReplacements =
                    weaponOverride.ProperReplacements?.ToDictionary(x => x.Key, y => y.Value) ??
                    new Dictionary<ulong, ulong>();

                List<STUHeroWeaponEntity> weaponEntities = new List<STUHeroWeaponEntity>();
                if (hero.WeaponComponents1 != null) {
                    weaponEntities.AddRange(hero.WeaponComponents1);
                }
                if (hero.WeaponComponents2 != null) {
                    weaponEntities.AddRange(hero.WeaponComponents2);
                }
                foreach (STUHeroWeaponEntity heroWeapon in weaponEntities) {
                    FindLogic.Combo.Find(info, heroWeapon.Entity, weaponReplacements);
                    STUModelComponent modelComponent = GetInstance<STUModelComponent>(heroWeapon.Entity);
                    if (modelComponent?.Look == null || weaponSkinName == null) continue;
                    ulong modelLook = FindLogic.Combo.GetReplacement(modelComponent.Look, weaponReplacements);
                    if (!info.ModelLooks.ContainsKey(modelLook)) continue;
                    FindLogic.Combo.ModelLookInfo modelLookInfo = info.ModelLooks[modelLook];
                    modelLookInfo.Name = weaponSkinName;
                }
                
                replacementIndex++;
            }
            info.Config.DoExistingEntities = false;

            foreach (Common.STUGUID guiImage in new[] {hero.ImageResource1, hero.ImageResource2, hero.ImageResource3, 
                hero.ImageResource3, hero.ImageResource4, skinOverride.SkinImage, hero.SpectatorIcon}) {
                FindLogic.Combo.Find(info, guiImage, replacements);
            }
            Combo.SaveLooseTextures(flags, Path.Combine(path, "GUI"), info);

            info.SetEntityName(hero.EntityHeroSelect, $"{heroName}-HeroSelect");
            info.SetEntityName(hero.EntityPlayable, $"{heroName}-Playable-ThirdPerson");
            info.SetEntityName(hero.EntityThirdPerson, $"{heroName}-ThirdPerson");
            info.SetEntityName(hero.EntityMain, $"{heroName}-Base");
            info.SetEntityName(hero.EntityHighlightIntro, $"{heroName}-HighlightIntro");

            string soundDirectory = Path.Combine(path, "Sound");
            
            FindLogic.Combo.ComboInfo diffInfoBefore = new FindLogic.Combo.ComboInfo();
            FindLogic.Combo.ComboInfo diffInfoAfter = new FindLogic.Combo.ComboInfo();

            if (replacements != null) {
                foreach (KeyValuePair<ulong,ulong> replacement in replacements) {
                    uint diffReplacementType = GUID.Type(replacement.Value);
                    if (diffReplacementType != 0x2C && diffReplacementType != 0x5F && diffReplacementType != 0x3F &&
                        diffReplacementType != 0xB2) continue;
                    FindLogic.Combo.Find(diffInfoAfter, replacement.Value);
                    FindLogic.Combo.Find(diffInfoBefore, replacement.Key);
                }
            
                diffInfoAfter.SaveRuntimeData = new FindLogic.Combo.ComboSaveRuntimeData {Threads = false};

                foreach (KeyValuePair<ulong,FindLogic.Combo.SoundFileInfo> soundFile in diffInfoAfter.SoundFiles) {
                    if (diffInfoBefore.SoundFiles.ContainsKey(soundFile.Key)) continue;
                    Combo.SaveSoundFile(flags, soundDirectory, diffInfoAfter, soundFile.Key, false);
                }
            
                foreach (KeyValuePair<ulong,FindLogic.Combo.SoundFileInfo> soundFile in diffInfoAfter.VoiceSoundFiles) {
                    if (diffInfoBefore.VoiceSoundFiles.ContainsKey(soundFile.Key)) continue;
                    Combo.SaveSoundFile(flags, soundDirectory, diffInfoAfter, soundFile.Key, true);
                }
            }
            
            LoudLog("\tSaving");
            Combo.Save(flags, path, info);            
            LoudLog("\tDone");
        }
        
        public static void Save(ICLIFlags flags, string path, STUHero hero, STUHeroSkin skin, bool quiet = true) {
            STUSkinOverride skinOverride = GetInstance<STUSkinOverride>(skin.SkinOverride);
            LoudLog($"Extracting skin {GetString(hero.Name)} {GetFileName(skin.SkinOverride)}");
            Save(flags, GetFileName(skin.SkinOverride), path, hero, "", skinOverride, null, null, quiet);
        }

        public static void Save(ICLIFlags flags, string path, STUHero hero, string rarity, STUUnlock_Skin skin, List<ItemInfo> weaponSkins, List<STULoadout> abilities, bool quiet=true) {
            if (skin == null) return;
            LoudLog($"Extracting skin {GetString(hero.Name)} {GetString(skin.CosmeticName)}");
            if (weaponSkins == null) weaponSkins = new List<ItemInfo>();
            
            STUSkinOverride skinOverride = GetInstance<STUSkinOverride>(skin.SkinResource);
            Save(flags, GetString(skin.CosmeticName).TrimEnd(' '), path, hero, rarity, skinOverride, weaponSkins, abilities, quiet);
        }
    }
}