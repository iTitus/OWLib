using System;
using System.Collections.Generic;
using System.Linq;
using DataTool.Flag;
using static DataTool.Program;
using static DataTool.Helper.STUHelper;
using Newtonsoft.Json;
using OWLib;
using TankLib;
using TankLib.STU.Types;
using Combo = DataTool.FindLogic.Combo;
using static DataTool.Helper.IO;
using STUHero = TankLib.STU.Types.STUHero;
using STUVoiceSetComponent = TankLib.STU.Types.STUVoiceSetComponent;


namespace DataTool.ToolLogic.Dump {
    [Tool("dump-hero-voice", Description = "Dumps all the strings", TrackTypes = new ushort[] { 0x75 }, CustomFlags = typeof(DumpFlags))]
    public class DumpHeroVoice : JSONTool, ITool {
        public void IntegrateView(object sender) {
            throw new NotImplementedException();
        }

        public class SoundInfo {
            public string HeroName;
            public string SoundFile;
            public string StimulusSet;
            public string Subtitle;

            [JsonIgnore]
            public ulong GUID;

            public SoundInfo(string heroName, ulong guid, ulong groupGuid, string subtitle) {
                GUID = guid;
                HeroName = heroName;
                SoundFile = $"{teResourceGUID.LongKey(guid):X12}";
                StimulusSet = $"{teResourceGUID.LongKey(groupGuid):X12}";
                Subtitle = subtitle;
            }
        }

        public void Parse(ICLIFlags toolFlags) {
            List<SoundInfo> soundList = new List<SoundInfo>();
            
            foreach (ulong heroFile in TrackedFiles[0x75]) {
                STUHero hero = GetInstanceNew<STUHero>(heroFile);
                if (hero == null) continue;
                
                string heroNameActual = (GetString(hero.m_0EDCE350) ?? $"Unknown{GUID.Index(heroFile)}").TrimEnd(' ');
                
                STUVoiceSetComponent voiceSetComponent = GetInstanceNew<STUVoiceSetComponent>(hero.m_gameplayEntity);

                if (voiceSetComponent?.m_voiceDefinition == null) continue;
                
                Combo.ComboInfo info = new Combo.ComboInfo();
                Combo.Find(info, voiceSetComponent.m_voiceDefinition);
                
                Combo.VoiceSetInfo voiceSetInfo = info.VoiceSets[voiceSetComponent.m_voiceDefinition];

                foreach (var stimuliSet in voiceSetInfo.VoiceLineInstances) {
                    foreach (var soundStimuli in stimuliSet.Value) {
                        var subtitleData = GetInstanceNew<STU_7A68A730>(soundStimuli.Subtitle);
                        var subtitle = subtitleData?.m_798027DE.m_text;

                        foreach (var sound in soundStimuli.SoundFiles) {
                            soundList.Add(new SoundInfo(heroNameActual, sound, soundStimuli.VoiceStimulus, subtitle));
                        }
                    }
                }
            }
            
            ParseJSON(
                soundList.OrderBy(s => s.GUID).ToList(),
                toolFlags as DumpFlags
            );
        }
    }
}