using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Drawing;

namespace gyak4_jlv3dc
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> flats;

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            load_data();
            create_excel();
        }

        void load_data()
        {
            flats = context.Flats.ToList();
        }

        void create_excel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                create_table();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(msg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        void create_table()
        {
            string[] headers = new string[] { "Kód", "Eladó", "Oldal", "Kerület", "Lift", "Szobák száma", "Alapterület (m2)", "Ár (mFt)", "Négyzetméter ár (Ft/m2)" };

            for (int i = 0; i < headers.Length; i++) xlSheet.Cells[1, i + 1] = headers[i];

            object[,] values = new object[flats.Count, headers.Length];

            int j = 0;
            foreach (Flat n in flats)
            {
                values[j, 0] = n.Code;
                values[j, 1] = n.Vendor;
                values[j, 2] = n.Side;
                values[j, 3] = n.District;
                if (n.Elevator) values[j, 4] = "van";
                else values[j, 4] = "nincs";
                values[j, 5] = n.NumberOfRooms;
                values[j, 6] = n.FloorArea;
                values[j, 7] = n.Price;
                values[j, 8] = "=" + what_cell(7, j) + "/" + what_cell(8, j);

                xlSheet.get_Range(what_cell(2, 1), what_cell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
                formatting(headers.Length);
            }
        }

        string what_cell(int x, int y)
        {
            string coordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                coordinate = Convert.ToChar(65 + modulo).ToString() + coordinate;
                dividend = (dividend - modulo) / 26;
            }
            coordinate += x.ToString();
            return coordinate;
        }

        void formatting(int l)
        {
            Excel.Range head = xlSheet.get_Range(what_cell(1, 1), what_cell(1, l));
            head.Font.Bold = true;
            head.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            head.EntireColumn.AutoFit();
            head.RowHeight = 40;
            head.Interior.Color = Color.LightBlue;
            head.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }
    }
}