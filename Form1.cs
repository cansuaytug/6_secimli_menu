using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cansu_nesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"..\..\cikti.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());

            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);


            int k = 0;

            if (s1 > s2)
            {
                k = s2;
            }
            else if (s2 > s1)
            {
                k = s1;
            }
            else
            {
                k = s1;
            }
            int ebob = 1;

            for (int i = 2; i <= k; i++)
            {
                if (s1 % i == 0 && s2 % i == 0)
                {

                    if (ebob < i)
                    {
                        ebob = i;
                    }
                }
            }
            string son = ebob.ToString();
            MessageBox.Show(son);
            sw.WriteLine("EBOB : " + ebob);
            sw.WriteLine(son);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"..\..\cikti.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // StreamWriter sw = new StreamWriter(fs); Console.WriteLine("s1");

            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());

            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            {

                int ekok = 1;
                int k;
                int ebob = 1;
                if (s1 > s2)
                    k = s1;
                else
                    k = s2;
                for (int i = 1; i <= k; i++)
                {
                    if ((s1 % i == 0) && (s2 % i == 0))
                    {
                        ebob = i;
                    }
                    ekok = (s1 * s2) / ebob;

                }


                string son = ekok.ToString();
                MessageBox.Show(son);
                sw.WriteLine("Ekok:{0}", ekok);
                sw.WriteLine(son);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"..\..\cikti.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            int toplam = 0, sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) toplam = toplam + i;
            }
            string son = toplam.ToString();
            MessageBox.Show(son);
            sw.WriteLine("Tum carpanların toplamini bul: " + sayi);
            sw.WriteLine(son);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"..\..\cikti.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            int s1, s2, ss2 = 0;
            float sonuc = 1, ss1;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (s2 == 0) sonuc = 1;
            if (s2 < 0)
            {
                ss1 = 1.0f / (s1 * 1.0f);
                ss2 = -s2;
                for (int i = ss2; i > 0; i--)
                {
                    sonuc = sonuc * ss1;
                }
            }
            if (s2 > 0)
            {
                for (int i = s2; i > 0; i--)
                {
                    sonuc = sonuc * s1;
                }
            }
            string son = sonuc.ToString();
            MessageBox.Show(son);
            sw.WriteLine("n’nin k. kuvvetini bul: " + s1 + " " + s2);
            sw.WriteLine(sonuc);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"..\..\cikti.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            int saat, dakika;
            float aci, xsa, ydk, akrep, yelkovan;
            saat = Convert.ToInt32(textBox1.Text);
            dakika = Convert.ToInt32(textBox2.Text);
            xsa = saat * 30;
            ydk = dakika * 0.5f;
            akrep = xsa + ydk;
            yelkovan = 6 * dakika;
            aci = akrep - yelkovan;
            if (aci > 180) aci = 360 - aci;
            string son = aci.ToString();
            MessageBox.Show(son);
            sw.WriteLine("Akreple yelkovan arasindaki dar aciyi bul: " + saat + " " + dakika);
            sw.WriteLine(son);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
