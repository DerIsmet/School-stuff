using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flaeche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string xstring;
        double x;
        string ystring;
        double y;
        double produkt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void T_laengewer_TextChanged(object sender, EventArgs e)
        {
            xstring = T_laengewer.Text;
            x = Convert.ToDouble(xstring);
        }

        private void T_breitewert_TextChanged(object sender, EventArgs e)
        {
            ystring = T_breitewert.Text;
            y = Convert.ToDouble(ystring);
        }

        private void B_rehnen_Click(object sender, EventArgs e)
        {
            produkt = x * y;
            T_flacheninhalt.Text = Convert.ToString(produkt);
        }
    }
}
