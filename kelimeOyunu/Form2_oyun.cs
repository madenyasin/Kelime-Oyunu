using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace kelimeOyunu
{
    public partial class Form2_oyun : Form
    {

        string filePathSorular;
        string filePathCevaplar;

        Form1 ff = new Form1();
        Random rnd = new Random();

        IntDiziIslemleri intDizi = new IntDiziIslemleri();
        FilePath path = new FilePath();
        Sesler ses = new Sesler();

        SoundPlayer harfAl;
        SoundPlayer yanlisCevap;
        SoundPlayer tebrikler;

        int totalPuan = 0, soruPuan = 400, zaman = 200, sayacDurdur = 30, i = 0;
        int level = 4, index = 0, alinanHarfSayisi = 0, cevapHarf = 0;

        string[] sorular = new string[1000];
        string[] cevaplar = new string[1000];

        int[] acilanHarfler = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        int[] acilanSorular = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        public Form2_oyun()
        {
            InitializeComponent();

            harfAl = ses.harfAl;
            yanlisCevap = ses.yanlisCevap;
            tebrikler = ses.tebrikler;

            filePathSorular = path.sorular_txt;
            filePathCevaplar = path.cevaplar_txt;

            sorular = System.IO.File.ReadAllLines(filePathSorular);
            cevaplar = System.IO.File.ReadAllLines(filePathCevaplar);

            levelBelirle();
            sonrakiSoru();

            lblTotalPuan.Text = totalPuan.ToString();
            lblSoruPuan.Text = soruPuan.ToString();

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Start();
            timer2.Stop();
        }
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();

            if (txtKullaniciCevap.Text.ToLower() == cevaplar[index].ToLower())
            {
                btnDurdur.Visible = true;
                btnHarfAl.Text = "Harf Al";
                btnHarfAl.Visible = true;

                timer2.Stop();
                sayacDurdur = 30;

                lblDurdurSayac.Text = Convert.ToString(sayacDurdur);
                timer1.Start();
                totalPuan += soruPuan;
                lblTotalPuan.Text = totalPuan.ToString();
                lblSoruPuan.Text = soruPuan.ToString();

                MessageBox.Show("Doğru");
                alinanHarfSayisi = 0;
                level++;
                if (level == 12)
                {
                    tebrikler.Play();
                    timer1.Stop();
                    MessageBox.Show("Tebrikler oyunu başarıyla bitirdin!\n Puanın: " + totalPuan + "\nKalan süre: " + zaman);
                    this.Hide();
                    ff.Activate();
                }
                txtKullaniciCevap.Text = "";
                sonrakiSoru();
                btnHarfAl.Visible = true;
            }
            else
            {
                yanlisCevap.Play();
                btnHarfAl.Visible = false;
                btnDurdur.Visible = false;
                MessageBox.Show("Yanlış");
                txtKullaniciCevap.Text = "";
            }
        }
        private void btnHarfAl_Click(object sender, EventArgs e)
        {

            if (alinanHarfSayisi != cevapHarf)
            {
                soruPuan -= 100;
                lblSoruPuan.Text = soruPuan.ToString();
                lblTotalPuan.Text = totalPuan.ToString();

                harfAl.Play();
                alinanHarfSayisi++;
                int i = rnd.Next(0, cevapHarf);
                while (intDizi.dizideVarMi(i, acilanHarfler))
                {
                    i = rnd.Next(0, cevapHarf);
                }
                acilanHarfler[alinanHarfSayisi - 1] = i;
                if (alinanHarfSayisi == cevapHarf)
                {
                    btnHarfAl.Text = "PAS\nGeç";
                    intDizi.diziyiTemizle(acilanHarfler);
                }
                if (i == 0)
                {
                    cevap0.Visible = true;
                    cevap0.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 1)
                {
                    cevap1.Visible = true;
                    cevap1.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 2)
                {
                    cevap2.Visible = true;
                    cevap2.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 3)
                {
                    cevap3.Visible = true;
                    cevap3.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 4)
                {
                    cevap4.Visible = true;
                    cevap4.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 5)
                {
                    cevap5.Visible = true;
                    cevap5.Text = cevaplar[index][i].ToString().ToUpper();
                }
                else if (i == 6)
                {
                    cevap6.Visible = true;
                    cevap6.Text = cevaplar[index][i].ToString().ToUpper();
                }
            }
            else
            {
                btnHarfAl.Text = "Harf Al";
                alinanHarfSayisi = 0;
                level++;
                if (level == 12)
                {
                    tebrikler.Play();
                    timer1.Stop();
                    MessageBox.Show("Tebrikler oyunu başarıyla bitirdin!\n Puanın: " + totalPuan + "\nKalan süre: " + zaman);
                    this.Hide();
                    ff.Activate();
                }
                else
                    sonrakiSoru();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            totalZaman.Text = Convert.ToString(zaman);
            if (zaman == 0)
            {
                yanlisCevap.Play();
                timer1.Stop();
                MessageBox.Show("Süre Bitti!\nPuanın: " + totalPuan);
                this.Hide();
                ff.Activate();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayacDurdur--;
            lblDurdurSayac.Text = Convert.ToString(sayacDurdur);
            if (sayacDurdur == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Süre Bitti!\nPuanın: " + totalPuan);
                this.Hide();
                ff.Activate();
            }
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            btnHarfAl.Visible = false;
            timer2.Start();
            timer1.Stop();
        }
        public void sonrakiSoru()
        {
            i++;
            if (level == 4 || level == 5)
                cevapHarf = 4;
            else if (level == 6 || level == 7)
                cevapHarf = 5;
            else if (level == 8 || level == 9)
                cevapHarf = 6;
            else if (level == 10 || level == 11)
                cevapHarf = 7;

            harfleriTemizle();
            levelBelirle();
            index = rnd.Next(0, sorular.Length);
            while ((cevaplar[index].Length != cevapHarf) || intDizi.dizideVarMi(index, acilanSorular))
            {
                index = rnd.Next(0, sorular.Length);
            }
            acilanSorular[i - 1] = index;
            if (sorular[index].Length > sorular[3].Length)
            {
                soruGostergesi.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                soruGostergesi.Text = sorular[index];
            }
            else
            {
                soruGostergesi.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                soruGostergesi.Text = sorular[index];
            }
            soruPuan = 100 * cevaplar[index].Length;
            lblSoruPuan.Text = soruPuan.ToString();
        }
        public void levelBelirle()
        {
            if (level >= 6)
                pictureBox5.Visible = true;
            if (level >= 8)
                pictureBox6.Visible = true;
            if (level >= 10)
                pictureBox7.Visible = true;
        }
        public void harfleriTemizle()
        {
            cevap0.Text = "";
            cevap1.Text = "";
            cevap2.Text = "";
            cevap3.Text = "";
            cevap4.Text = "";
            cevap5.Text = "";
            cevap6.Text = "";
        }

    }
    public class FilePath
    {
        public string sorular_txt = "sorular.txt";//@"C:\Users\Yasin\source\repos\kelimeOyunu\kelimeOyunu\bin\Debug\net6.0-windows\sorular.txt";
        public string cevaplar_txt = "cevaplar.txt";//@"C:\Users\Yasin\source\repos\kelimeOyunu\kelimeOyunu\bin\Debug\net6.0-windows\cevaplar.txt";
    }
    public class Sesler
    {
        public SoundPlayer harfAl = new SoundPlayer(Properties.Resources.harfAlSesEfekti);
        public SoundPlayer yanlisCevap = new SoundPlayer(Properties.Resources.yanlisCevapSesEfekti);
        public SoundPlayer tebrikler = new SoundPlayer(Properties.Resources.tebriklerSesEfekti);
    }
    public class IntDiziIslemleri
    {
        public void diziyiTemizle(int[] dizi)
        {
            int i = 0;
            while (i < dizi.Length)
            {
                dizi[i] = -1;
                i++;
            }
        }
        public bool dizideVarMi(int x, int[] dizi)
        {
            int i = 0;
            while (i < dizi.Length)
            {
                if (dizi[i] == x)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
