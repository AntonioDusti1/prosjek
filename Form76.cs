using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak21
{
    public partial class Form1 : Form
    {
        List<Prosjek> listaOcjena = new List<Prosjek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo napraviti provjeru podataka 
            //try...catch
            //ocjena mora biti od 1 do 5
            // predmet ne smije biti prazan string
            Prosjek prosjek = new Prosjek(comboBox1.Text, Convert.ToInt32(textBox1.Text));
            listaOcjena.Add(prosjek);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach(Prosjek prosjek in listaOcjena)
            {
                textBox2.AppendText(prosjek.NazivPredmeta
                    + "\t" +
                    prosjek.Ocijene + "\r\n");
            }
        }

        private void Učitaj_Click(object sender, EventArgs e)
        {
            //Ovdje ide kod za učitavanje .csv datoteke
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
