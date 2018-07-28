﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DataTool.DataModels;
using DataTool.Flag;
using DataTool.ToolLogic.Extract;
using STULib.Types;
using static DataTool.Helper.IO;

namespace DataTool.SaveLogic.Unlock {
    public class SprayAndIcon {
        public static void SaveItems(string basePath, string heroName, string containerName, string folderName, ICLIFlags flags, List<ItemInfo> items) {
            foreach (ItemInfo item in items) {
                SaveItem(basePath, heroName, containerName, folderName, flags, item);
            }
        }


        public static void SaveItem(string basePath, string heroName, string containerName, string folderName, ICLIFlags flags, ItemInfo item) {
            if (item == null) return;
            string name = GetValidFilename(item.Name).TrimEnd(' ').Replace(".", "");
            string type;

            switch (item.Unlock) {
                case STUUnlock_PlayerIcon _:
                    type = "Icons";
                    break;
                case STUUnlock_Spray _:
                    type = "Sprays";
                    break;
                default:
                    return;
            }
            
            FindLogic.Combo.ComboInfo info = new FindLogic.Combo.ComboInfo();
            FindLogic.Combo.Find(info, item.GUID);
            
            string output = Path.Combine(basePath, containerName, heroName ?? "", type, folderName, name);
            
            // hmm, resaving the default spray over and over again (ref'd by SSCE) is kinda bad.
            
            Combo.SaveLooseTextures(flags, output, info, true);

            if (((ExtractFlags) flags).SaveNamesAsFileNames) return;
            
            Combo.SaveAllMaterials(flags, output, info);
            Combo.Save(flags, output, info);
        }
    }
}