using System.Reflection;
using System.Reflection.Emit;
using System.Text.Json;
using Newtonsoft.Json;
namespace Serilazation_Deserialization
{

    public partial class Form1 : Form
    {
        //Ürünleri tutacağımz liste
        List<Urun> urunListesi = new List<Urun>();

        public Form1()
        {
            InitializeComponent();
        }

        //ürünleri listeden alıp yazdıracağımız kısım
        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            if (File.Exists("urunler.json"))
            {
                using (StreamReader sr = new StreamReader("urunler.json"))
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    urunListesi = serializer.Deserialize<List<Urun>>(reader);
                }

                listUrunler.Items.Clear();

                foreach (var urun in urunListesi)
                {
                    listUrunler.Items.Add($"Ad: {urun.UrunAdi}, Fiyat: {urun.UrunFiyati}₺");
                }
            }
            else
            {
                MessageBox.Show("JSON dosyası bulunamadı.");
            }
        }


        private void btnJsonCreate_Click(object sender, EventArgs e)
        {
            //Fiyatın doğru girilmesi için bir if bloğu.
            if (!int.TryParse(txtFiyat.Text, out int fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            Urun yeniUrun = new Urun
            {
                UrunAdi = txtAd.Text,
                UrunFiyati = fiyat
            };


            if (File.Exists("urunler.json"))
            {
                using (StreamReader sr = new StreamReader("urunler.json"))
                using (JsonTextReader reader = new JsonTextReader(sr))
                {

                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    var mevcutListe = serializer.Deserialize<List<Urun>>(reader);
                    if (mevcutListe != null)
                        urunListesi = mevcutListe;

                }
            }

            //Yeni ürünü listeye ekledik
            urunListesi.Add(yeniUrun);


            using (StreamWriter sw = new StreamWriter("urunler.json"))
            using (JsonTextWriter writer = new JsonTextWriter(sw))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Formatting = Newtonsoft.Json.Formatting.Indented; //okunabilir bir json dosyası oluşturmak için kullandım.
                serializer.Serialize(writer, urunListesi);
            }

            txtAd.Text = "";
            txtFiyat.Text = "";
            MessageBox.Show("Ürün eklendi ve JSON dosyası güncellendi.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listUrunler.Items.Clear();

            // Bellekteki listeyi sıfırlamak için
            urunListesi.Clear();

            // JSON dosyasını temizlemek için kullanıldı
            if (File.Exists("urunler.json"))
            {
                File.Delete("urunler.json");
            }

            MessageBox.Show("Tüm ürünler silindi.");
        }

        private void btnReflection_Click(object sender, EventArgs e)
        {
            Type tip = typeof(Urun);
            PropertyInfo[] ozellikler = tip.GetProperties();

            if (lstProps.Items.Count > 0)
            {
                MessageBox.Show("Özellikler zaten listelenmiş");
            }
            else
            {
                foreach (var ozellik in ozellikler)
                {
                    lstProps.Items.Add("Özellik: " + ozellik.Name);
                }
            }
        }
    }
}
