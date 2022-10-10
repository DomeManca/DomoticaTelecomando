using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando
{
    public partial class Telecomando : Form
    {
        private TV tv;
        
        public Telecomando()
        {
            InitializeComponent();
            tv = new TV();
            Reset();
            label8.Text = "";
            label9.Text = "";
        }
        public void Reset()
        {
            label8.Text = "1";
            label9.Text = "15";
            label10.Text = "";
            label6.Text = "Modello";
            textBox2.Text = "Modello";
            label7.Text = "Produttore";
            textBox1.Text = "Produttore";
            label7.Text = "Produttore";
            tv.resetSegnale("Infrarossi");
            numericUpDown2.Value = 15;
            numericUpDown3.Value = 1;
        }
        public void Spegnimento()
        {
            label8.Text = "1";
            label9.Text = "15";
            numericUpDown2.Value = 15;
            numericUpDown3.Value = 1;
        }1bb
        private void button1_Click(object sender, EventArgs e)
        {
            if(tv.inverti()== true)
            {
                tv.accendi();
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                tv.spegni();
                pictureBox1.BackColor = Color.White; 
                Spegnimento();
                pictureBox1.BackColor = Color.White;
                Reset();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
                label10.Text = tv.setSegnale();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown2.Value);
            if (tv.getStato() == true)
                label9.Text = Convert.ToString(tv.setVolume(n));
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown3.Value);
            if (n == 0)
            {
                numericUpDown3.Value = 999;
                n = 999;
            }
            if (n == 1000)
            {
                numericUpDown3.Value = 1;
                n = 1;
            }
            if (tv.getStato() == true)
                label8.Text = Convert.ToString(tv.setCanale(n));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                if(label9.Text == "0")
                {
                    label9.Text = Convert.ToString(numericUpDown2.Value);
                    numericUpDown2.Enabled = true;
                }
                else
                {
                    label9.Text = "0";
                    numericUpDown2.Enabled = false;
                }
            }  
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
                label7.Text = tv.setProduttore(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
                label6.Text = tv.setProduttore(textBox2.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            MessageBox.Show("Reset avvenuto con successo!", "SUCCESSO");
        }
    }
}
