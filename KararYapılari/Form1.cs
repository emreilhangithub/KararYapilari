using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapılari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
           if (sayi % 2 == 0 && sayi >= 10)
            {
                label1.Text = "10 dan büyük ve çifttir";
            }
           else
            {
                label1.Text = "10 küçük veya tekdir";
            }
        }
    }
}
