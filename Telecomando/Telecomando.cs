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
        }
        public void Reset()
        {
            label10.Text = "";
            textBox2.Text = "Modello";
            textBox1.Text = "Produttore";
            tv.setSegnale("Infrarossi");
        }
        public void Accensione()
        {
            label8.Text = "1";
            label9.Text = "15";
            numericUpDown2.Value = 15;
            numericUpDown3.Value = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(tv.inverti()== true)
            {
                tv.accendi();
                Accensione();
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                tv.spegni();
                pictureBox1.BackColor = Color.White;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                tv.switchSegnale();
                label10.Text = tv.getSegnale();
            }      
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown2.Value);
            if (tv.getStato() == true)
            {
                tv.setVolume(n);
                label9.Text = Convert.ToString(tv.getVolume());
            }
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
            {
                tv.setCanale(n);
                label8.Text = Convert.ToString(tv.getCanale());
            }
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
            {
                tv.setProduttore(textBox1.Text);
                label7.Text = tv.getProduttore();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tv.getStato() == true)
            {
                tv.setModello(textBox2.Text);
                label6.Text = tv.getModello();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (tv.getStato() == false)
                Reset();
            MessageBox.Show("Reset avvenuto con successo!", "SUCCESSO");
        }
    }
}
