using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Quiz8_E_Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;

            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\\Data.accdb";
            cmd.CommandText = "INSERT INTO kayıt(DersAdi,1Sinav,2Sinav,1Performans,2Performans,1Uygulama,Notu,Ad,Soyad,VeliAd,VeliSoyad) values(@DersAdi,@1Sinav,@2Sinav,@1Performans,@2Performans,@1Uygulama,@Notu,@Ad,@Soyad,@VeliAd,@VeliSoyad)";
            cmd.Parameters.Add("@DersAdi", OleDbType.VarChar).Value = cmbders.Text;
            cmd.Parameters.Add("@1Sinav", OleDbType.VarChar).Value = txt1s.Text;
            cmd.Parameters.Add("@2Sinav", OleDbType.VarChar).Value = txt2s.Text;
            cmd.Parameters.Add("@1Performans", OleDbType.VarChar).Value = txt1p.Text;
            cmd.Parameters.Add("@2Performans", OleDbType.VarChar).Value = txt2p.Text;
            cmd.Parameters.Add("@1uygulama", OleDbType.VarChar).Value = txtu.Text;
            cmd.Parameters.Add("@Notu", OleDbType.VarChar).Value = txtno.Text;
            cmd.Parameters.Add("@Ad", OleDbType.VarChar).Value = txtad.Text;
            cmd.Parameters.Add("@Soyad", OleDbType.VarChar).Value = txtsoyad.Text;
            cmd.Parameters.Add("@VeliAd", OleDbType.VarChar).Value = txtvad.Text;
            cmd.Parameters.Add("@VeliSoyad", OleDbType.VarChar).Value = txtvsoyad.Text;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Kaydınınz Başarıyla Gerçekleştirildi");
            txt1s.Clear(); txt2s.Clear(); txt1p.Clear(); txt2p.Clear(); txtu.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNotDegistirme n = new FormNotDegistirme();
            n.Show();
            this.Hide();
        }
    }
}
