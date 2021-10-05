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
    public partial class Form1 : Form
    {
        bool turn = true;
        int turncount = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void BClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";
            turn = !turn;
            button.Enabled = false;
            turncount++;
            winneralgor();
        }

        private void winneralgor()
        {
            bool winner = false;

            //tic tac toe kombinacije
            if (((b1.Text == "X") && (b4.Text == "X") && (b7.Text == "X")) || ((b4.Text == "O") && (b1.Text == "O") && (b7.Text == "O")))
                winner = true;
            else if (((b2.Text == "X") && (b5.Text == "X") && (b8.Text == "X")) || ((b2.Text == "O") && (b5.Text == "O") && (b8.Text == "O")))
                winner = true;
            else if (((b3.Text == "X") && (b6.Text == "X") && (b9.Text == "X")) || ((b3.Text == "O") && (b6.Text == "O") && (b9.Text == "O")))
                winner = true;

            if (((b1.Text == "X") && (b2.Text == "X") && (b3.Text == "X")) || ((b1.Text == "O") && (b2.Text == "O") && (b3.Text == "O")))
                winner = true;
            else if (((b4.Text == "X") && (b5.Text == "X") && (b6.Text == "X")) || ((b5.Text == "O") && (b6.Text == "O") && (b7.Text == "O")))
                winner = true;
            else if (((b7.Text == "X") && (b8.Text == "X") && (b9.Text == "X")) || ((b7.Text == "O") && (b8.Text == "O") && (b9.Text == "O")))
                winner = true;

            if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
                winner = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
                winner = true;

            if (winner)
            {
                disableButtons(); // 
                string win = "";
                if (turn)
                {
                    win = igrac2;
                    labeligrac2.Text = (Int32.Parse(labeligrac2.Text) + 1).ToString();
                }
                else
                {
                    win = igrac1;
                    labeligrac1.Text = (Int32.Parse(labeligrac1.Text) + 1).ToString();
                }
                MessageBox.Show(win + " je pobjedio!", win + "je pobjedio!");
            }
            else
            {
                if (turncount == 9)
                {
                    labelnerijeseno.Text = (Int32.Parse(labelnerijeseno.Text) + 1).ToString();
                    MessageBox.Show("Izjednačeno!", "Neriješeno!");
                }
            }
        }

        private void disableButtons()
        {
            b1.Enabled = false;

            b2.Enabled = false;

            b3.Enabled = false;

            b4.Enabled = false;

            b5.Enabled = false;

            b6.Enabled = false;

            b7.Enabled = false;

            b8.Enabled = false;

            b9.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Reset - Nova igra button
            labelnerijeseno.Text = "0"; // .Text da converta u string, logicno
            labeligrac1.Text = "0";
            labeligrac2.Text = "0";

            turn = true;
            turncount = 0;
            // Praznjenje x i o iz buttona, te njihovo "omogucivanje"
            b1.Enabled = true;
            b1.Text = "";

            b2.Enabled = true;
            b2.Text = "";

            b3.Enabled = true;
            b3.Text = "";

            b4.Enabled = true;
            b4.Text = "";

            b5.Enabled = true;
            b5.Text = "";

            b6.Enabled = true;
            b6.Text = "";

            b7.Enabled = true;
            b7.Text = "";

            b8.Enabled = true;
            b8.Text = "";

            b9.Enabled = true;
            b9.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turn = true;
            turncount = 0;
            // Praznjenje x i o iz buttona, te njihovo "omogucivanje"
            b1.Enabled = true;
            b1.Text = "";

            b2.Enabled = true;
            b2.Text = "";

            b3.Enabled = true;
            b3.Text = "";

            b4.Enabled = true;
            b4.Text = "";

            b5.Enabled = true;
            b5.Text = "";

            b6.Enabled = true;
            b6.Text = "";

            b7.Enabled = true;
            b7.Text = "";

            b8.Enabled = true;
            b8.Text = "";

            b9.Enabled = true;
            b9.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); // izlaz 
        }

        static String igrac1, igrac2; // mora biti static zbog objektne reference
        public static void setPlayer(String name1, String name2)
        {
            igrac1 = name1;
            igrac2 = name2;
        }

        private void Form1Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if(label2.Text =="" && label3.Text == "")
            {
                label2.Text = label2.Text;
                label3.Text = label3.Text;
            }
            label2.Text = igrac1;
            label3.Text = igrac2;
        }
    }

}
