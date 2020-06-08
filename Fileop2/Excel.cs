using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Fileop2
{
    class Excel
    {

        string inputFilePath = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            this.inputFilePath = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
         
        public Excel()
        {
            wb = excel.Workbooks.Add(Type.Missing);
            ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;
            ws.Name = "StudentRepoertCard";
            ws = wb.Worksheets.get_Item(1);
        }

        public string ReadCell(int i, int j)
        {
            if (ws.Cells[i, j].value2 != null)
            {
                return ws.Cells[i, j].value2;
            }
            else
            {
                return "";
            }
        }

        public void save()
        {
            wb.Save();
        }

        public void saveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void close()
        {
            wb.Close();
        }

        public void writetoCell(int row, int column, string text)
        {
            ws.Cells[row, column].value2 = text;
        }

    }
}
