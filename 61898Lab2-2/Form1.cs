using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61898Lab2_2
{
    public partial class Form1 : Form
    {
        int rozmiar_czcionki;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    rozmiar_czcionki = 16;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki);
                }
                if (radioButton2.Checked == true)
                {
                    rozmiar_czcionki = 18;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki);
                }
                if (radioButton3.Checked == true)
                {
                    rozmiar_czcionki = 20;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki);
                }
            }
            else
            {
                MessageBox.Show("Podaj wybrany rozmiar tekstu");
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
            {
                if (radioButton4.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (radioButton5.Checked == true)
                {
                    textBox1.ForeColor = Color.Blue;
                }
                if (radioButton6.Checked == true)
                {
                    textBox1.ForeColor = Color.Orange;
                }
            }
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                if ((radioButton4.Checked == false) && (radioButton5.Checked == false) && (radioButton6.Checked == false))
                {
                    MessageBox.Show("Jaki pierwszy kolor chcesz wybrac?");
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Italic | FontStyle.Underline);
                }
                else if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Bold);
                }
                else if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Italic);
                }
                else if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, rozmiar_czcionki, FontStyle.Underline);
                }
            }
        }
    }
}
