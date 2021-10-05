using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gubo_Kruzic_Krizic___Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

    

        private void Form2Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Defaultna imena postavljena", "Nema unosa!");
            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Form1.setPlayer(textBox1.Text, textBox2.Text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {

                MessageBox.Show("Defaultna imena postavljena", "Nema unosa!");
            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Form1.setPlayer(textBox1.Text, textBox2.Text);
            }
           
                this.Close();
        }
    }
}
