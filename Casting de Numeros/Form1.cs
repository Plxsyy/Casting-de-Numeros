using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting_de_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Division2(textBox1.Text);
            doublenumber(textBox1.Text);
            textBox3.Text = Convert.ToString(Division2(textBox1.Text));
            textBox4.Text = Convert.ToString(doublenumber(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Division2(textBox2.Text);
            doublenumber(textBox2.Text);
            textBox3.Text= Convert.ToString(Division2(textBox2.Text));
            textBox4.Text=Convert.ToString( doublenumber(textBox2.Text));
        }
        public int Division2 (string num) {
            int numt=Convert.ToInt32(num);
            int division = numt / 2;
            return division;

        }
        public int doublenumber(string num)
        {
            int numt =Convert.ToInt32(num);
            int doublenum = numt * 2;
            return doublenum;

        }

        
    }
}
