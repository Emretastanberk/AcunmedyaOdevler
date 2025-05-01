using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;
using Reflection.Attributes;
using Reflection.Interfaces;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OdemeYontemleriniYukle(); //Odeme yöntemlerini comboBoxa yükler
        }
        private void OdemeYontemleriniYukle()
        {
            // Reflection kullanılarak IOdemeYontemi arayüzünü implemente eden tüm sınıflar bulunur
            var odemeTipleri = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            cmbOdemeYontemi.Items.AddRange(odemeTipleri.Select(t => t.Name).ToArray());
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            // Girilen tutarın sayısal olup olmadığı ve bir yöntem seçilip seçilmediği kontrol edilir
            if (decimal.TryParse(txtTutar.Text, out decimal tutar) && cmbOdemeYontemi.SelectedItem != null)
            {
                string secilenSinif = cmbOdemeYontemi.SelectedItem.ToString();
                // Assembly içinden sınıf tipi bulunur
                Type sinifTipi = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == secilenSinif);

                if (sinifTipi != null)
                {
                    // Activator ile sınıfın bir örneği runtime'da oluşturulur
                    IOdemeYontemi odemeYontemi = (IOdemeYontemi)Activator.CreateInstance(sinifTipi);
                    // Ode metodu çağrılır ve sonuç ekrana yazdırılır
                    lblSonuc.Text = odemeYontemi.Ode(tutar);
                }
            }
            else
            {
                lblSonuc.Text = "Geçerli bir tutar giriniz ve bir yöntem seçiniz.";
            }
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lstListBox.Items.Clear(); // Önceki verileri temizle
                    string secilenKlasor = dialog.SelectedPath;

                    // Alt klasörlerdeki class'ları listele
                    KlasorleriVeClasslariListele(secilenKlasor);
                }
            }
        }

        private void KlasorleriVeClasslariListele(string rootPath)
        {
            // Tüm alt klasörleri al
            var klasorler = Directory.GetDirectories(rootPath);

            foreach (var klasor in klasorler)
            {
                string klasorAdi = Path.GetFileName(klasor);
                lstListBox.Items.Add(klasorAdi); // Ana klasör ismi

                // Bu klasördeki tüm .cs dosyalarını al
                var dosyalar = Directory.GetFiles(klasor, "*.cs");

                foreach (var dosya in dosyalar)
                {
                    // Her dosyayı satır satır oku
                    var satirlar = File.ReadAllLines(dosya);

                    foreach (var satir in satirlar)
                    {
                        // 'class' tanımı içeren satırı kontrol et
                        if (satir.Trim().StartsWith("public class") || satir.Trim().StartsWith("class"))
                        {
                            // Class adını regex ile ayıkla
                            var match = Regex.Match(satir, @"class\s+(\w+)");
                            if (match.Success)
                            {
                                string classAdi = match.Groups[1].Value;
                                lstListBox.Items.Add("    " + classAdi); // Girintili olarak ekle
                            }
                        }
                    }
                }
            }
        }

        //Attribute tanımlama ve okuma
        private void btnAttributeUse_Click(object sender, EventArgs e)
        {
            lstAttribute.Items.Clear();
            Type type = typeof(ExampleClass);
            object[] attributes = type.GetCustomAttributes(typeof(Attribute), false);

            foreach (AAuthor attr in attributes)
            {
                lstAttribute.Items.Add("Yazarı: " + attr.Name);
            }
        }


        [AAuthor("Ahmet Yılmaz")] // ExampleClass adlı sınıfa attribute eklendi.
        public class ExampleClass
        {
            public void Write()
            {
                Console.WriteLine("Kod çalışıyor.");
            }
        }

        private void btnAttributeControl_Click(object sender, EventArgs e)
        {
            lstAttributeControl.Items.Clear();
            var user = new AUser();
            user.Ad = txtName.Text;
            user.Email = txtMail.Text;
            user.Yas = Convert.ToInt32(txtAge.Text);
      
            var context = new ValidationContext(user);
            var errors = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(user,context,errors, true);

            if (!isValid)
            {
                foreach (var error in errors)
                {
                    lstAttributeControl.Items.Add("Hata: " + error.ErrorMessage);

                    
                }
                
            }
            else
            {
                lstAttributeControl.Items.Clear();
                lstAttributeControl.Items.Add("Bilgiler Geçerli");
                
            }
            


        }
    }
}
