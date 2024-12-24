using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneshardSaveScum
{
    public static class QuickAction
    {

        public static string SaveSlotOne = "BackUp1";
        public static string SaveSlotTwo = "Backup2";
        public static string SaveSlotThree = "Backup3";
        public static string SaveSlotFour = "Backup4";
        public static string SaveSlotFive = "Backup5";
        public static bool IsValidFolderPath(string path)
        {
            var dataSavPath = Path.Combine(path, "data.sav");
            var previewPNGPath = Path.Combine(path, "preview.png");
            var saveMapPath = Path.Combine(path, "save.map");

            var isDataSavExist = File.Exists(dataSavPath);
            var isPreviewPNGExist = File.Exists(previewPNGPath);
            var isSaveMapExist = File.Exists(saveMapPath);

            var isValid = Directory.Exists(path) && isDataSavExist && isPreviewPNGExist && isSaveMapExist;

            return isValid;
        }

        public static void CopyAllFileFromAToB(string pathA, string pathB)
        {
            try
            {
                if (!Directory.Exists(pathB))
                {
                    Directory.CreateDirectory(pathB);
                }
                // Get all files from the source folder
                string[] files = Directory.GetFiles(pathA);

                foreach (string file in files)
                {
                    // Get the file name
                    string fileName = Path.GetFileName(file);

                    // Create the destination file path
                    string destFilePath = Path.Combine(pathB, fileName);

                    // Copy the file
                    File.Copy(file, destFilePath, overwrite: true);
                }
            }
            catch (Exception)
            {
                // Pretend nothing happened lol
            }
        }
    }
}
