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

        private void button2_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;
            s1 = Convert.ToDouble(textBox2.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            proje = Convert.ToDouble(textBox4.Text);
            ort = (s1 + s2 + proje) / 3;
            if(ort >= 50)
            {
                durum = "geçti";
            }
            else
            {
                durum = "kaldı";
            }
            textBox5.Text = ort.ToString("0.00")+"/" + durum;          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //0-20 ==> %20 
            //21-40 ==> %40 
            //41++ ==> %50 
            //Kitap 8 ₺

            int kitapadet, indirimorani;
            double toplam,normaltp,indirimli;
            kitapadet = Convert.ToInt16(textBox6.Text);
            normaltp = kitapadet * 8;
            label8.Text = normaltp + "₺";
            if (kitapadet >=0 && kitapadet <=20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label9.Text = toplam + "₺";
                indirimli = kitapadet * 8 * 0.20;               
                label12.Text = indirimli + "₺";
                indirimorani = 20;
                label13.Text = "%" + indirimorani;
            }

            else if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label9.Text = toplam + "₺";
                indirimli = kitapadet * 8 * 0.40;
                label12.Text = indirimli + "₺";
                indirimorani = 40;
                label13.Text = "%" + indirimorani;
            }

            else if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label9.Text = toplam + "₺";
                indirimli = kitapadet * 8 * 0.50;
                label12.Text = indirimli + "₺";
                indirimorani = 50;
                label13.Text = "%" + indirimorani;
            }
            else
            {
                label9.Text = "Lütfen 0 dan küçük değer girmeyeniz";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox7.Text);

            switch (ay)
            {
                case 1:  label15.Text = "Ocak"; break;
                case 2:  label15.Text = "Şubat"; break;
                case 3:  label15.Text = "Mart"; break;
                case 4:  label15.Text = "Nisan"; break;
                case 5:  label15.Text = "Mayıs"; break;
                case 6:  label15.Text = "Haziran"; break;
                case 7:  label15.Text = "Temmuz"; break;
                case 8:  label15.Text = "Agustos"; break;
                case 9:  label15.Text = "Eylül"; break;
                case 10: label15.Text = "Ekim"; break;
                case 11: label15.Text = "Kasım"; break;
                case 12: label15.Text = "Aralık"; break;
                default: label15.Text = "Ay bilgisini yanlış girdiniz."; break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mevsim = textBox8.Text;
            switch(mevsim)
            {
                case "yaz": label18.Text = "Haziran Temmuz Ağustos"; break;
                case "sonbahar": label18.Text = "Eylül Ekim Kasım"; break;
                case "kış": label18.Text = "Aralık Ocak Şubat"; break;
                case "ilkbahar": label18.Text = "Mart Nisan Mayıs"; break;
                default: label18.Text = "Hatalı mevsim girdiniz."; break;
            }
        }

     
    }
}
