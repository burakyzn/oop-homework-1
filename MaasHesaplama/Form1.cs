using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MaasHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // program açýlýþýnda gruplarý etkisizleþtir ve veri etiketlerini görünmez yap.
            GruplarýEtkisizlestir();
            EtiketleriGorunmezYap();
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        { // seçilen txt dosyasýný richtextboxta açmak için yazýlmýþ kod
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader dosya = new System.IO.StreamReader(openFileDialog1.FileName);
                rTxtPersonelBilgi.Text = dosya.ReadToEnd();
                dosya.Close();

                grpPersonelBilgi.Enabled = true;
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {

            if (txtKimlik.Text == String.Empty)
            { // txtKimlik boþ býrakýlmýþsa uyarý ver
                uyariMesaji.Clear();
                uyariMesaji.SetError(txtKimlik, "Bu alan boþ býrakýlamaz!");
                FormElemanlariniTemizle();
            }
            else if (txtKimlik.Text.Length != 11)
            { // txtKimlik 11 haneden küçük býrakýlmýþsa uyarý ver.
                uyariMesaji.Clear();
                uyariMesaji.SetError(txtKimlik, "TC kimlik numarasý 11 haneden kýsa olamaz!");
                FormElemanlariniTemizle();
            }
            else
            {
                uyariMesaji.Clear();

                string[] kisiler;

                string tumPersonelListesi = rTxtPersonelBilgi.Text;
                kisiler = tumPersonelListesi.Split('\n');

                bool personelBulundumu = false;
                for (int i = 0; i < kisiler.Length; i++)
                {
                    string[] kisilerDetay = kisiler[i].Split(' ');

                    if (kisilerDetay[0] == txtKimlik.Text)
                    {
                        // TC'si girilen personel bulunduysa gruplarý etkinlestir ve bilgileri doldur.
                        personelBulundumu = true;
                        GruplariEtkinlestir();
                        BilgileriDoldur(kisilerDetay);

                        // hesaplama iþlemleri bir sýnýfýn statik fonksiyonlarý aracýlýðýyla yapýlýyor.
                        lblBrutMaas.Text = Hesapla.BrutMaas(kisilerDetay);
                        lblDamgaVergi.Text = Hesapla.DamgaVergisi(lblBrutMaas.Text);
                        lblGelirVergi.Text = Hesapla.GelirVergisi(lblBrutMaas.Text, lblVergiMat.Text);
                        lblEmekliKes.Text = Hesapla.EmekliKesintisi(lblBrutMaas.Text);
                        lblNetMaas.Text = Hesapla.NetMaas(lblBrutMaas.Text, lblEmekliKes.Text,
                                                             lblGelirVergi.Text, lblDamgaVergi.Text);

                        EtiketleriGorunurYap();
                    }
                }

                if (personelBulundumu == false)
                { // txtKimlik textboxuna girilen tc ile uyusan personel yoksa hata mesajý goster.
                    MessageBox.Show("Girilen TC kimlik numarasý ile uyuþan personel bulunmamaktadýr.");
                    FormElemanlariniTemizle();
                }

            }
        }

        private void txtKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txtKimlik textboxuna tc icin en fazla 11 hane ile sýnýrla.
            // sayýdan ve silme tusundan baska tus kabul edilmiyor.
            txtKimlik.MaxLength = 11;
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void EtiketleriGorunurYap()
        {
            // labelleri goster
            lblAd.Visible = true;
            lblSoyad.Visible = true;
            lblYas.Visible = true;
            lblCalismaSure.Visible = true;
            lblEvlilikDurum.Visible = true;
            lblEsCalis.Visible = true;
            lblCocukSa.Visible = true;
            lblTabanMaas.Visible = true;
            lblMakTazminat.Visible = true;
            lblGorevTazminat.Visible = true;
            lblVergiMat.Visible = true;
            lblMesai.Visible = true;
            lblMesaiUcret.Visible = true;
            lblDamgaVergi.Visible = true;
            lblEmekliKes.Visible = true;
            lblBrutMaas.Visible = true;
            lblGelirVergi.Visible = true;
            lblNetMaas.Visible = true;
            lblTC.Visible = true;
            

        }

        public void EtiketleriGorunmezYap()
        {
            //labellarý gizle
            lblNetMaas.Visible = false;
            lblTC.Visible = false;
            lblAd.Visible = false;
            lblSoyad.Visible = false;
            lblYas.Visible = false;
            lblCalismaSure.Visible = false;
            lblCocukSa.Visible = false;
            lblEvlilikDurum.Visible = false;
            lblEsCalis.Visible = false;
            lblTabanMaas.Visible = false;
            lblMakTazminat.Visible = false;
            lblGorevTazminat.Visible = false;
            lblVergiMat.Visible = false;
            lblMesai.Visible = false;
            lblMesaiUcret.Visible = false;
            lblDamgaVergi.Visible = false;
            lblEmekliKes.Visible = false;
            lblBrutMaas.Visible = false;
            lblGelirVergi.Visible = false;


        }

        public void GruplarýEtkisizlestir()
        { 
            // gruplarý etkisizlestir
            grpPersonelBilgi.Enabled = false;
            grpKisiselBilgi.Enabled = false;
            grpDigerBilgi.Enabled = false;
            grpMaasBilgi.Enabled = false;
        }

        public void GruplariEtkinlestir()
        {
            // gruplarý etkinlestir
            grpKisiselBilgi.Enabled = true;
            grpDigerBilgi.Enabled = true;
            grpMaasBilgi.Enabled = true;
        }

        public void BilgileriDoldur(string[] personelBilgi)
        {
            // txt dosyasindan okunan verileri label nesnelerine aktardigim kisim 

            lblTC.Text = personelBilgi[0];
            lblAd.Text = personelBilgi[1];
            lblSoyad.Text = personelBilgi[2];
            lblYas.Text = personelBilgi[3];
            lblCalismaSure.Text = personelBilgi[4];

            if (personelBilgi[5] == "E")
                lblEvlilikDurum.Text = "Evli";
            else
            {
                lblEvlilikDurum.Text = "Bekar";
                lblEsCalis.Enabled = false;
                lblEsBilgi.Enabled = false;
            }

            if (personelBilgi[6] == "H")
                lblEsCalis.Text = "Hayýr";
            else
                lblEsCalis.Text = "Evet";

            lblCocukSa.Text = personelBilgi[7];
            lblTabanMaas.Text = personelBilgi[8];
            lblMakTazminat.Text = personelBilgi[9];
            lblGorevTazminat.Text = personelBilgi[10];
            lblMesai.Text = personelBilgi[11];
            lblMesaiUcret.Text = personelBilgi[12];
            lblVergiMat.Text = personelBilgi[13];



            string fotografDizini = personelBilgi[14];
            if (File.Exists(fotografDizini) == true) // resim dosyasý var mi kontrol et
            {
                // varsa dosyayý yukle goster
                personelFotograf.Image = Image.FromFile(personelBilgi[14]);
            }
            else
            {
                // yoksa uyari mesaji cikar
                uyariMesaji.SetError(personelFotograf, "Personel fotoðrafý belirtilen dizinde bulunmuyor!");
                Image hataResmi = personelFotograf.ErrorImage;
                personelFotograf.Image = hataResmi;
            }
        }

        public void FormElemanlariniTemizle()
        {
            // her hangi bir hata durumunda baslangic anina donmek icin form elamanlari uzerindeki islemler
            EtiketleriGorunmezYap();
            GruplarýEtkisizlestir();
            grpPersonelBilgi.Enabled = true;
            personelFotograf.Image = null;
            txtKimlik.Clear();
            txtKimlik.Focus();
        }
    } 
}
