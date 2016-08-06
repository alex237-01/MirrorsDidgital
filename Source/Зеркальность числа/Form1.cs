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
            if(textBox1.Text != string.Empty)
            a =Convert.ToInt64(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
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

            while(itt!=1000)
            {
                b+=Convert.ToInt64(coup(b.ToString()));
                itt++;
                if(b.ToString() ==coup(b.ToString()))
                    return itt;
            }
            return 0;
        }
 
    }
}
