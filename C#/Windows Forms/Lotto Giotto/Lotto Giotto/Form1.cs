using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_Giotto
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool[] lotto = new bool[50];
        int anzahl = 0;
        Random rand = new Random();
        int zufallszahl = 0;
        


        private void B_spielfeldini_Click(object sender, EventArgs e)
        {
            LB_spielefeld.Items.Clear();
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = false;
            }
        }

        private void B_fixetestzahlen_Click(object sender, EventArgs e)
        {
            lotto[1] = true;
            lotto[3] = true;
            lotto[5] = true;
            lotto[7] = true;
            lotto[11] = true;
        }

        private void B_ausgabespielfeld_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == true)
                {
                    LB_spielefeld.Items.Add("Lotto[" + i + "]: X");
                }else
                {
                    LB_spielefeld.Items.Add("Lotto[" + i + "]: O");
                }
            {
                
            }
            }
        }

        private void B_ausgabederlottozahlen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == true)
                {
                    LB_lottozahlen.Items.Add(i);
                }
            }
           
        }

        private void B_lottospielen_Click(object sender, EventArgs e)
        {
            while (anzahl < 6)
            {
                zufallszahl = rand.Next(1, 50);
                if(lotto[zufallszahl] == false)
                {
                    lotto[zufallszahl] = true;
                    anzahl++;
                }

            }

        }
    }
}
