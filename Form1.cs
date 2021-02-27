using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using NPOI.SS.Formula.Functions;

namespace hesap_makinesi
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        decimal sayı1 = 0;
        decimal sayı2 = 0;
        string operasyon;
        decimal result = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 20 || textBox2.TextLength == 20)
            {
                MessageBox.Show("En fazla 20 rakam yazılabilir");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            sayı1 = 1;
            sayı2 = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (operasyon == "toplam")
                {
                    sayı2 = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = (sayı1.ToString() + "+" + sayı2.ToString());
                    result = Convert.ToDecimal(sayı1) + Convert.ToDecimal(sayı2);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "bolualma")
                {
                    result = 1 / Convert.ToDecimal(sayı1);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "-")
                {
                    sayı2 = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = (sayı1.ToString() + "-" + sayı2.ToString());
                    result = Convert.ToDecimal(sayı1) - Convert.ToDecimal(sayı2);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "*")
                {
                    sayı2 = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = (sayı1.ToString() + "*" + sayı2.ToString());
                    result = Convert.ToDecimal(sayı1) * Convert.ToDecimal(sayı2);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "/")
                {
                    sayı2 = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = (sayı1.ToString() + "/" + sayı2.ToString());
                    result = Convert.ToDecimal(sayı1) / Convert.ToDecimal(sayı2);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "karealma")
                {
                    textBox1.Text = (sayı1.ToString() + "  " + "x²");
                    result = Convert.ToDecimal(sayı1) * Convert.ToDecimal(sayı1);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "kupalma")
                {
                    textBox1.Text = (sayı1.ToString() + "  " + "X³");
                    result = Convert.ToDecimal(sayı1) * Convert.ToDecimal(sayı1) * Convert.ToDecimal(sayı1);
                    textBox2.Text = result.ToString();
                }
                if (operasyon == "karekokalma")
                {
                    textBox1.Text = (sayı1.ToString() + "  " + "X³");
                    double abc = Convert.ToDouble(sayı1);
                    result = Convert.ToDecimal(Math.Sqrt(abc));
                    textBox2.Text = result.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void cıkarma_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }
                operasyon = "-";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void carpma_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }

                operasyon = "*";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void bolme_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }

                operasyon = "/";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void kare_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                }

                operasyon = "karealma";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void kup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }

                operasyon = "kupalma";
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");

            }

        }

        private void karekok_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }

                operasyon = "karekokalma";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void bolualma_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                }

                operasyon = "bolualma";
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }

        }

        private void Toplama_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    sayı1 = decimal.Parse(textBox1.Text);
                    textBox1.Text = null;
                    textBox2.Text = sayı1.ToString();
                    operasyon = "toplam";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }



        }
    }
}
