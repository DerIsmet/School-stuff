using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithmen_zu_arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] z = new int[10];
        int xinput;
        string xstring;



        private void B_initialisieren_Click(object sender, EventArgs e)
        {
            xstring = T_input.Text;
            xinput = Convert.ToInt32(xstring);
            for (int i = 0; i < 10; i++)
            {
                z[i] = xinput;
            }

        }

    }
}
