using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hintergrundfarbe_des_Formulars_aendern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;

        }

        private void B_rot_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void B_blau_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }
    }
}
