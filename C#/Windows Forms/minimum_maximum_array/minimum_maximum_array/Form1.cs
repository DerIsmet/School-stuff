using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimum_maximum_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hoeste = -1;
        int index = -1;
        int zahl = 0;
        int [] zahlen = new int [10];
        Random random = new Random();
        

        private void B_Max_Click(object sender, EventArgs e)
        {
            LB_Ausgabe.Items.Clear();
            for (int i = 0; i <= 9; i++)
            {
                zahlen[i] = random.Next(0, 51);
                zahl++;
                LB_Ausgabe.Items.Add("Zuffalszahl "+zahl+": "+zahlen[i].ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                if(zahlen[i] > hoeste)
                {
                    hoeste = zahlen[i];
                    index = i;
                }
            }
            MessageBox.Show("Der Höchste Wert ist "+hoeste.ToString());

        }

        private void B_min_Click(object sender, EventArgs e)
        {
            LB_Ausgabe.Items.Clear();

            for (int i = 0; i <= 9; i++)
            {

                zahlen[i] = random.Next(0, 51);
                zahl++;
                LB_Ausgabe.Items.Add("Zuffalszahl " + zahl + ": " + zahlen[i].ToString());
            }
            int kleinste = zahlen[0];
            for (int i = 0; i < 10; i++)
            {
                if (zahlen[i] < kleinste)
                {
                    kleinste = zahlen[i];
                    index = i;
                }
            }
            MessageBox.Show("Der Kleinste Wert ist " + kleinste.ToString());
        }
    }
}
