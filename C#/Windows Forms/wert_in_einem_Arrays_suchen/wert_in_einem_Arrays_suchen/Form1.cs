using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wert_in_einem_Arrays_suchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int userinput;
        string userstring;
        int position = -1;
        private void B_zufall_Click(object sender, EventArgs e)
        {
            Random zufallwerte = new Random();
            int randomnumber = zufallwerte.Next(1, 101);
            int[] z = new int[10];

            for (int i = 0; i < 10; i++)
            {
                z[i] = randomnumber;
            }
            userstring = T_wertdenmansucht.Text;
            userinput = Convert.ToInt32(userstring);
            for (int i = 0; i < 10; i++)
            {
                if (z[i] == userinput)
                {
                    position = i;
                }
            }
            if(position != -1)
            {
                L_ausgabetext.Text = ("Der Wert " + userinput + " ist im Element z[" + position + "]");
            }
            else
            {
                L_ausgabetext.Text = ("Der Wert " + userinput + " ist nicht vor");

            }

        }
    }
}
