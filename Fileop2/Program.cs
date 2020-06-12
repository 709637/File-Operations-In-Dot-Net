using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileop2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Excel Reader---------------------------------------------------------------------------------------------------------

            //Excel excel = new Excel(@"F:\Node_JS & Projects\InputFolder\copy of FEEDBACK PENDING CASES.xlsx", 1);
            ////Excel excel = new Excel(@"F:\Node_JS & Projects\InputFolder\Writeto This.xlsx", 2);
            ////Excel excel = new Excel();

            //Console.WriteLine(excel.ReadCell(3, 2));        


            //excel.writetoCell(2, 1, "Hello");
            ////excel.save();
            //excel.saveAs(@"F:\Node_JS & Projects\InputFolder\Excel From Code1.xlsx");
            //excel.close();

            //Console.WriteLine("Done....");
            //Console.ReadKey();

            //Excel Reader---------------------------------------------------------------------------------------------------------


            //XML Reader-----------------------------------------------------------------------------------------------------------

            //xmlReader xmlRead = new xmlReader();
            //xmlRead.Readxml();
            //Console.WriteLine("Done....");
            //Console.ReadKey();

            //XML Reader-----------------------------------------------------------------------------------------------------------

            //Read AppConfig-------------------------------------------------------------------------------------------------------

            //ReadAppConfig rac = new ReadAppConfig();
            //rac.ReadAppConfigFile();
            //Console.WriteLine("Done....");
            //Console.ReadKey();

            //Read AppConfig-------------------------------------------------------------------------------------------------------

            //PDF Operations-------------------------------------------------------------------------------------------------------

            //PDF_File pdfop = new PDF_File();
            //pdfop.pdfOperataion();


            //PDF Operations-------------------------------------------------------------------------------------------------------
            Console.WriteLine(args[0]+ args[1]);   // pass the properties from Right click on project name  --> Debug --> Command line argument
            Console.ReadKey();
        }
    }
}
