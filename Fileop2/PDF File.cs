using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;

namespace Fileop2
{
    class PDF_File
    {

        public void pdfOperataion()
        {
            string inputFolderPath = @"F:\Node_JS & Projects\InputFolder\Terms & Conditions.pdf";

            //Getting All or only JPG Files and printing the name-------------------------------------------------------------------

            //string[] Files = Directory.GetFiles(@"C:\Users\VipulSingh\Downloads")   //Reads all file
            string[] Files = Directory.GetFiles(@"C:\Users\VipulSingh\Downloads", "*.jpg");  // Reads only the jpg files
            foreach (string filename in Files)
            {
                Console.WriteLine(filename);
            }

            //Getting All or only JPG Files and printing the name-------------------------------------------------------------------





            //Inserting text in PDF File at a perticular place----------------------------------------------------------------------

            DocumentCore dc = DocumentCore.Load(inputFolderPath);
            ContentRange cr = dc.Content.Find("Use of the Website&app").FirstOrDefault();
            cr.Start.Insert("\n pankaj is here lets show him\n");
            dc.Save(inputFolderPath);
            string str = dc.Content.ToString();
            Console.WriteLine(str);
            Console.WriteLine("Above Content");
            if (dc != null)
            {

            }

            //Inserting text in PDF File at a perticular place---------------------------------------------------------------------- 


            string inputDirectory = @"F:\Node_JS & Projects\InputFolder\";
            string outputFileName = @"F:\Node_JS & Projects\OutputFolder\output.pdf";

            //Getting All PDF Files to be merged----------------------------------------------------------------------------------


            DirectoryInfo di = new DirectoryInfo(inputDirectory);
            FileInfo[] fileinfo = di.GetFiles("*.pdf");
            string[] fileNames = new string[fileinfo.Length];
            int i = 0;
            foreach (var fileName in fileinfo)
            {
                fileNames[i] = fileName.FullName;
                i++;
            }


            //Getting All PDF Files to be merged----------------------------------------------------------------------------------

            //Merging multiple PDF Files-------------------------------------------------------------------------------------------

            PdfDocument outputPdfDocument = new PdfDocument();

            foreach (string fileName in fileNames)
            {
                PdfDocument inputPdfDocument = PdfReader.Open(fileName, PdfDocumentOpenMode.Import);

                int pages = inputPdfDocument.PageCount;
                for (int j = 0; j < pages; j++)
                {
                    PdfPage page = inputPdfDocument.Pages[j];
                    outputPdfDocument.AddPage(page);
                }
            }

            outputPdfDocument.Save(outputFileName);

            //Merging multiple PDF Files-------------------------------------------------------------------------------------------

            Console.ReadKey();
        }

        

    }
}
