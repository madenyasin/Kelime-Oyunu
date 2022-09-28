using System.Media;
using System.Reflection;

namespace kelimeOyunu
{
    public partial class Form1 : Form
    {
        PathFile path = new PathFile();
        
        string filePathSorular;
        string filePathCevaplar;
        
        
        public Form1()
        {
            InitializeComponent();
            filePathSorular = path.sorular_txt;
            filePathCevaplar = path.cevaplar_txt;
        }
       
        private async void btnSoruEkle_Click(object sender, EventArgs e)
        {
            if (txtSoruEkle.Text != "" && txtCevapEkle.Text != "")
            {
                using StreamWriter file1 = new(filePathSorular, append: true);
                await file1.WriteLineAsync(txtSoruEkle.Text);
                using StreamWriter file2 = new(filePathCevaplar, append: true);
                await file2.WriteLineAsync(txtCevapEkle.Text);
                txtCevapEkle.Text = "";
                txtSoruEkle.Text = "";
            }
            else
            {
                MessageBox.Show("Gerekli alanlarý doldurun...");
            }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            
            Form2_oyun ff = new Form2_oyun();
            ff.Show();   
        }
        
    }
    public class PathFile
    {
        public string sorular_txt = "sorular.txt";//@"C:\Users\Yasin\source\repos\kelimeOyunu\kelimeOyunu\bin\Debug\net6.0-windows\sorular.txt";
        public string cevaplar_txt = "cevaplar.txt";//@"C:\Users\Yasin\source\repos\kelimeOyunu\kelimeOyunu\bin\Debug\net6.0-windows\cevaplar.txt";
    }
}