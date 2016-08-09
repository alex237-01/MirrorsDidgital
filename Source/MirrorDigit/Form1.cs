using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        long a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
                a = Convert.ToInt64(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (a.ToString() == coup(a.ToString()))
            {
                label2.Text = "Число зеркально";
                label3.Text = "Кол-во иттераций 0";
            }
            else
            {
                if (itter(a) != 0)
                {
                    label2.Text = "Число не зеркально";
                    label3.Text = "Число зеркально через " + itter(a);
                }
                else
                {
                    label2.Text = "Число не зеркально";
                    label3.Text = "Число не зеркально даже через 1000 иттераций";
                }
            }
        }

        static string coup(string b)
        {
            string tmp = string.Empty;

            for (int i = b.Length - 1; i >= 0; i--)
            {
                tmp += b[i];
            }

            return tmp;
        }

        static int itter(long b)
        {
            int itt = 0;

            while (itt != 1000)
            {
                b += Convert.ToInt64(coup(b.ToString()));
                itt++;
                if (b.ToString() == coup(b.ToString()))
                    return itt;
            }
            return 0;
        }

        static string da(int a)
        {
            return a.ToString();
        }

        static string add(string d, string d1)
        {
            string g = string.Empty;
            bool flap = true;
            byte a1 = 0;

            for (int i = d.Length - 1; i >= 0; i--)
            {
                int a = Convert.ToInt32(d[i].ToString());
                int b = Convert.ToInt32(d1[i].ToString());

                if ((a + b) > 9)
                {
                    flap = true;
                    a -= 10;
                    a1++;
                }

                if (a1 == 1)
                {
                    if (flap)
                    {
                        g = (a + b).ToString() + g;
                        flap = false;
                    }
                    else
                    {
                        g = (a + b + 1).ToString() + g;
                        flap = true;
                        a1 = 0;
                    }
                }
                else
                {
                    g = (a + b).ToString() + g;
                }
            }

            return g;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = add("725", "231");
        }
    }
}
