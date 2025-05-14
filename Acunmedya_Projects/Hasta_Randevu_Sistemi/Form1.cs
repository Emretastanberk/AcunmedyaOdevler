using System.Data;
using System.Data.SqlClient;


namespace Hasta_Randevu_Sistemi
{

    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hasta_Randevu_Sistemi;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            SaatleriYukle();
            BranslariGetir();

        }

        private void BranslariGetir()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            SqlCommand komut = new SqlCommand("SELECT * FROM Branslar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "Id";
            cmbBrans.DataSource = dt;
        }

        private void SaatleriYukle()
        {
            cmbSaat.Items.AddRange(new string[] { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" });
        }




        private void txtHastaAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            if (txtHastaAdi.Text == "" || txtHastaSoyadi.Text == "" || cmbBrans.SelectedIndex == -1 || cmbDoktor.SelectedIndex == -1 || cmbSaat.SelectedIndex == -1)
            {
                lblDurum.Text = "Lütfen tüm alanlarý doldurun.";
                return;
            }

            DateTime secilenTarihSaat = DateTime.Parse(dtpTarih.Value.ToString("yyyy-MM-dd") + " " + cmbSaat.SelectedItem.ToString());

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID=@doktor AND Tarih=@tarih", baglanti);
            kontrol.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
            kontrol.Parameters.AddWithValue("@tarih", secilenTarihSaat);
            baglanti.Open();
            int sayi = (int)kontrol.ExecuteScalar();
            baglanti.Close();

            if (sayi > 0)
            {
                lblDurum.Text = "Bu saatte randevu dolu!";
                return;
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@ad, @soyad, @brans, @doktor, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtHastaAdi.Text);
            komut.Parameters.AddWithValue("@soyad", txtHastaSoyadi.Text);
            komut.Parameters.AddWithValue("@brans", cmbBrans.SelectedValue);
            komut.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
            komut.Parameters.AddWithValue("@tarih", secilenTarihSaat);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            lblDurum.Text = "Randevu baþarýyla oluþturuldu!";
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            SqlCommand komut = new SqlCommand("SELECT * FROM Doktorlar WHERE BransID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbBrans.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDoktor.DisplayMember = "DoktorAdi";
            cmbDoktor.ValueMember = "Id";
            cmbDoktor.DataSource = dt;
        }
    }
}
