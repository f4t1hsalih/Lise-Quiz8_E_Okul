using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Quiz8_E_Okul
{
    public partial class FormNotDegistirme : Form
    {
        public FormNotDegistirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\\Data.accdb";
            cmd.Connection = cnn;

            cmd.CommandText = "update kayıt set 1Sinav=@1Sinav,2Sinav=@2Sinav,1Performans=@1Performans,2Performans=@2Performans,1Uygulama=@1Uygulama where No=@No and DersAdi=@DersAdi";
            cmd.Parameters.Add("@1Sinav", OleDbType.VarChar).Value = txt1s.Text;
            cmd.Parameters.Add("@2Sinav", OleDbType.VarChar).Value = txt2s.Text;
            cmd.Parameters.Add("@1Performans", OleDbType.VarChar).Value = txt1p.Text;
            cmd.Parameters.Add("@2Performans", OleDbType.VarChar).Value = txt2p.Text;
            cmd.Parameters.Add("@1uygulama", OleDbType.VarChar).Value = txtu.Text;
            cmd.Parameters.Add("@No", OleDbType.VarChar).Value = txtno.Text;
            cmd.Parameters.Add("@DersAdi", OleDbType.VarChar).Value = cmbders.Text;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Değiştirme İşlemi Gerçekleşti");
            txt1s.Clear(); txt2s.Clear(); txt1p.Clear(); txt2p.Clear(); txtu.Clear(); txtno.Clear();
        }
    }
}
