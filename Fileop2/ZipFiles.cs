using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fileop2
{
    class ZipFiles
    {
        string[] allFiles = Directory.GetFiles(@"F:\Node_JS & Projects\InputFolder\ZipIt");
        
        public void makeZipFiles()
        {
            foreach (string fileNam in allFiles)
            {
                string fileName = Path.GetFileName(fileNam);
                string outputFile = @"F:\Node_JS & Projects\OutputFolder\"+ fileName + ".zip";

                using (FileStream fileStream = File.Open(outputFile, FileMode.Create))
                {
                    GZipStream zipstream = new GZipStream(fileStream, CompressionMode.Compress);
                    byte[] byteArr = File.ReadAllBytes(fileNam);
                    zipstream.Write(byteArr, (int)zipstream.Length , (int)zipstream.Length + byteArr.Length);
                    zipstream.Close();
                    zipstream.Dispose();
                }
            }
        }
        

        public void multipleFileZip(string outputFileName)
        {
            //Your input folder path below
            string[] allFiles = Directory.GetFiles(@"F:\Node_JS & Projects\InputFolder\");
            var zip = ZipFile.Open(outputFileName, ZipArchiveMode.Create);
            foreach (var file in allFiles)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
            }
            // Dispose of the object when we are done
            zip.Dispose();
        }


        public void readingZipFileNames()
        {
            ZipArchive zip = ZipFile.OpenRead(@"F:\Node_JS & Projects\OutputFolder\AllFiles.zip");
            foreach (ZipArchiveEntry entry in zip.Entries)
            {
                Console.WriteLine(entry.FullName);
            }
        }

        public void extractAllFiles()
        {
            ZipFile.ExtractToDirectory(@"F:\Node_JS & Projects\OutputFolder\AllFiles.zip", @"F:\Node_JS & Projects\OutputFolder\ExtractedFiles\");
        }


    }
}
