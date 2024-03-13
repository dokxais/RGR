using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string buff;
        state CurrentState;
        string memory = "";
        string memory2 = "";
        enum state
        {
            substraction,
addiction,
            multiplication,
            divide,
            nonstate
    }
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
            }
            catch (Exception) { }

        }

        private void buttonOEMComma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            textBox1.Focus();

        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            CurrentState = state.addiction;
            buff = textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentState == state.divide)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "/" + double.Parse(textBox1.Text) + "=";
                    textBox1.Text = (double.Parse(buff) / buff2).ToString();
                }
                if (CurrentState == state.multiplication)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "*" + double.Parse(textBox1.Text) + "=";
                    textBox1.Text = (double.Parse(buff) * buff2).ToString();
                }
                if (CurrentState == state.substraction)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    //textBox1.Text = double.Parse(buff).ToString() + "-" + double.Parse(textBox1.Text) + "=";
                    textBox1.Text = (double.Parse(buff) - buff2).ToString();
                }
                if (CurrentState == state.addiction)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    // textBox1.Text = double.Parse(buff).ToString() + "+" + double.Parse(textBox1.Text) + "=";
                    textBox1.Text = (double.Parse(buff) + buff2).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попыткевводаневерныхданных");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.substraction;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Math.Pow(double.Parse(textBox1.Text), 2)).ToString();//x^2
            }
            catch (Exception)
            {
                MessageBox.Show("Попытайтесьввестикорректныедля\nданнойоперацииданныеиповторите", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Focus();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Focus();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Focus();

        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.multiplication;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();

            }

        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();//);
            }
            catch (Exception) { }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Focus();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Focus();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Focus();

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.divide;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                }

            }
            catch (Exception) { }

        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch (Exception) { }

        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CurrentState = state.nonstate;
            buff = "";

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            MemoryClearButton.Enabled = false;
            button11.Enabled = false;
            memory = "";
            label1.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    MemoryClearButton.Enabled = true;
                    button11.Enabled = true;
                    memory = textBox1.Text;
                    label1.Text = "M";
                }
                else
                {
                    MessageBox.Show("Попытайтесьввестикорректныедля\nданнойоперацииданныеиповторите", "Калькулятор", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        }
    

