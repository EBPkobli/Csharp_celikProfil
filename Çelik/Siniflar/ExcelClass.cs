using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; 

namespace excel_veri_çekme_konsol
{
    class ExcelClass
    {

        private string _excelYol { get; set; }
        private int _i { get; set; }
        private int _j { get; set; }
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkbook;
        private Excel._Worksheet xlWorksheet;
        private Excel.Range xlRange;

        public ExcelClass(string ExcelYol,int Satir,int Sutun)
        {
            _excelYol = ExcelYol;
            _i = Satir;
            _j = Sutun;

        }
        public void excelOku(ref List<string> Okunan )
        {
            

            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(_excelYol);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;
            for (int i = 1; i <= _i; i++)
            {
                for (int j = 1; j <= _j; j++)
                {

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        Okunan.Add(xlRange.Cells[i, j].Value2.ToString());
                    }

  
                }
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();


            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);


            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
