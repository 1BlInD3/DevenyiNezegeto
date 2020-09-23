using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp7
{
    class Excel
    {
        _Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;


        public void WorkBookClose()
        {
            workbook.Close(0);
        }
        public void ExcelClose()
        {
            excel.Quit();
        }
    }
}
