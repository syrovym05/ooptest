using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }
        Zamestanec zamestanec;
        Pacient pacient;
        private void button1_Click(object sender, EventArgs e)
        {
            zamestanec = new Zamestanec(textBox1.Text,textBox3.Text, (int)numericUpDown1.Value, textBox2.Text);
            button2.Enabled = true;
            button3.Enabled = true;
            label4.Text = zamestanec.ToString();



            Zamestanec zamestanec2 = new Zamestanec("Leoš", "Havlíček", 5, "Dětský lékař");
            Zamestanec zamestanec3 = new Zamestanec("Radek", "Chudoba", 28, "Dermatolog");
            zamestanec3.ZmenPlat(26000);
            label13.Text = zamestanec2.ToString();
            label14.Text = zamestanec3.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zamestanec.ZmenPlat((int)numericUpDown2.Value);
            label4.Text = zamestanec.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = zamestanec.ZjistiJmeno();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pacient = new Pacient(textBox5.Text, textBox4.Text, textBox6.Text,(int)numericUpDown3.Value);
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            label19.Text = pacient.ToString();

            Pacient pacient2 = new Pacient("Lucie", "Krátká", "789789456", 123);
            pacient2.NestandartniPristup = true;
            Pacient pacient3 = new Pacient("Simona", "Nováková" ,"555689113", 135);
            label17.Text = pacient2.ToString();
            label16.Text = pacient3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label21.Text = pacient.ZjistiJmeno();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pacient.Pokoj = (int)numericUpDown4.Value;
            label19.Text = pacient.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pacient.ZmenTelefon(textBox7.Text);
            label19.Text = pacient.ToString();
        }
    }
}
