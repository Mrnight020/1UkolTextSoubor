using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1TextSoubor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int soucet = 0;
                int pocetlichych = 0;
                int pocetsudych = 0;
                int cislo;
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                StreamReader cisla = new StreamReader("cislo.txt");
                while (!cisla.EndOfStream)
                {
                    cislo = int.Parse(cisla.ReadLine());
                    listBox1.Items.Add(cislo);
                    soucet += cislo;
                    if (cislo % 2 == 0) { pocetsudych++; } else { pocetlichych++; }
                }
                cisla.Close();

                MessageBox.Show("Soucet :" + soucet + "\nPocetsudych: " + pocetsudych + "\nPocetLichych: " + pocetlichych);

                StreamWriter zapisovac = new StreamWriter("cislo.txt", true);
                zapisovac.WriteLine(soucet);
                zapisovac.WriteLine(pocetsudych);
                zapisovac.WriteLine(pocetlichych);
                zapisovac.Close();

                StreamReader cisla2 = new StreamReader("cislo.txt");
                while (!cisla2.EndOfStream)
                {
                    listBox2.Items.Add(cisla2.ReadLine());

                }
                cisla2.Close();
            }
            catch { MessageBox.Show("Někde se stala chyba :)"); }
            

        }
    }
}
