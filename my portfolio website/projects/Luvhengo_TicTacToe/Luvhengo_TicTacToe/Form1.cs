using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Windows;
using System.Windows.Input;




namespace Luvhengo_TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;


        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false; 
        }

        void score()
        {
           
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Violet;
                button4.BackColor = Color.Violet;
                button7.BackColor = Color.Violet;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.CadetBlue;
                button5.BackColor = Color.CadetBlue;
                button8.BackColor = Color.CadetBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.SlateBlue;
                button6.BackColor = Color.SlateBlue;
                button9.BackColor = Color.SlateBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.DarkSlateBlue;
                button5.BackColor = Color.DarkSlateBlue;
                button6.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.DarkSlateBlue;
                button8.BackColor = Color.DarkSlateBlue;
                button9.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //Player O 
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Violet;
                button4.BackColor = Color.Violet;
                button7.BackColor = Color.Violet;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.CadetBlue;
                button5.BackColor = Color.CadetBlue;
                button8.BackColor = Color.CadetBlue;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.SlateBlue;
                button6.BackColor = Color.SlateBlue;
                button9.BackColor = Color.SlateBlue;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.DarkSlateBlue;
                button5.BackColor = Color.DarkSlateBlue;
                button6.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.DarkSlateBlue;
                button8.BackColor = Color.DarkSlateBlue;
                button9.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone +1);
                Enable_False();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";


                button1.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;
                button7.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                label4.Text = "0";
                label5.Text = "0";

                button10.Enabled = true;

                button1.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                button3.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;
                button7.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure you want to Exit?", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
