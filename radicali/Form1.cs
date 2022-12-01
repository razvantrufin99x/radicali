using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radicali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Se citeşte o valoare reală. Să se determine radical din x cu 5 zecimale exacte pe baza şirului
//convergent xn=1/2(xn-1+x/xn-1), cu x0>0 arbitrar ales.


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x,xn,xn_1;

            x = double.Parse(textBox1.Text);

            xn=1;
            do{
            xn_1=xn;
            xn=0.5*(xn_1+x/xn_1);
            } while (Math.Abs(xn-xn_1)<1e-5);
            textBox2.Text += x.ToString() +" : " + Math.Pow(x,0.5).ToString() + "\r\n";

        }
    }
}
