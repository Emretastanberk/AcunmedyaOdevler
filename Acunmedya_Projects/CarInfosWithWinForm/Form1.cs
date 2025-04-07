namespace CarInfosWithWinForm
{
    public partial class Form1 : Form
    {

        string marka;
        string model;
        string renk;
        string kapiSayisi;
        string pencereSayisi;
        string yakitTüketimi;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            marka = txtMarka.Text;
            model = txtModel.Text;
            renk = txtRenk.Text;
            yakitTüketimi = txtYakit.Text;

            lblBilgiler.Text = $"Arabanın markası: {marka}, modeli: {model}, rengi: {renk}, pencere sayısı: {pencereSayisi}, kapı sayısı: {kapiSayisi}, \n100 km’de Yaktığı Yakıt :{yakitTüketimi}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            pencereSayisi = cmbPencereSayisi.SelectedItem.ToString();   //Burada seçilen pencere sayısını pencereSayisi değişkenine atıyoruz
        }

        private void cmbKapiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            kapiSayisi = cmbKapiSayisi.SelectedItem.ToString();     //Burada seçilen kapı sayısını kapiSayisi değişkenine atıyoruz
        }
    }
}
