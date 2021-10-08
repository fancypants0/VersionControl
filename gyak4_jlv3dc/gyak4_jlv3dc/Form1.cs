using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace gyak4_jlv3dc
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> flats;

        public Form1()
        {
            InitializeComponent();
            load_data();
        }

        void load_data()
        {
            flats = context.Flats.ToList();
        }
    }
}
