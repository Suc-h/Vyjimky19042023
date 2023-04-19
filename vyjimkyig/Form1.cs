using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyjimkyig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rng = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            listBox1.Items.Clear();

            try
            {

                n = int.Parse(textBox2.Text);
                int[] pole = new int[n];
                for (int i = 0; i < n; i++)
                {

                    int voe = rng.Next(1, 21);

                    pole[i] = voe;

                    listBox1.Items.Add(voe);



                }
                double cislo=0;
                checked { cislo= Math.Pow(pole[0], pole[5]);}
                int cislo2 = Convert.ToInt32(cislo);
                label2.Text = "" + cislo2;
                pole = null;

            }
            catch (IndexOutOfRangeException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (FormatException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (OverflowException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (ArithmeticException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (Exception prace)
            {
                label1.Text = prace.ToString();
            }


            
        }
    }
}
