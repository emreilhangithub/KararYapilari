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
           if(textBox1.Text == "Mustafa")
            {
                label1.Text = "Başarılı";
            }
           else
            {
                label1.Text = "Hatalı";
            }
        }
    }
}
