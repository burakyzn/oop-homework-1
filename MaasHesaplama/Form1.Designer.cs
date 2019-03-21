namespace MaasHesaplama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.grpPersonelDosya = new System.Windows.Forms.GroupBox();
            this.rTxtPersonelBilgi = new System.Windows.Forms.RichTextBox();
            this.grpPersonelBilgi = new System.Windows.Forms.GroupBox();
            this.grpMaasBilgi = new System.Windows.Forms.GroupBox();
            this.lblNetMaas = new System.Windows.Forms.Label();
            this.lblBrutMaas = new System.Windows.Forms.Label();
            this.lblNetBilgi = new System.Windows.Forms.Label();
            this.lblGelirBilgi = new System.Windows.Forms.Label();
            this.lblEmekliKes = new System.Windows.Forms.Label();
            this.lblGelirVergi = new System.Windows.Forms.Label();
            this.lblDamgaBilgi = new System.Windows.Forms.Label();
            this.lblBrutBilgi = new System.Windows.Forms.Label();
            this.lblEmekBilgi = new System.Windows.Forms.Label();
            this.lblDamgaVergi = new System.Windows.Forms.Label();
            this.grpDigerBilgi = new System.Windows.Forms.GroupBox();
            this.lblMesaiUcret = new System.Windows.Forms.Label();
            this.lblMesai = new System.Windows.Forms.Label();
            this.lblMesaiUcBilgi = new System.Windows.Forms.Label();
            this.lblVergiMat = new System.Windows.Forms.Label();
            this.lblVergiBilgi = new System.Windows.Forms.Label();
            this.lblGorevTazminat = new System.Windows.Forms.Label();
            this.lblMesaiBilgi = new System.Windows.Forms.Label();
            this.lblMakTazminat = new System.Windows.Forms.Label();
            this.lblGorTazBilgi = new System.Windows.Forms.Label();
            this.lblMakTazBilgi = new System.Windows.Forms.Label();
            this.lblTabanMaas = new System.Windows.Forms.Label();
            this.lblTabanBilgi = new System.Windows.Forms.Label();
            this.grpKisiselBilgi = new System.Windows.Forms.GroupBox();
            this.lblCocukBilgi = new System.Windows.Forms.Label();
            this.lblCocukSa = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTCBilgi = new System.Windows.Forms.Label();
            this.lblEsBilgi = new System.Windows.Forms.Label();
            this.personelFotograf = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lblEsCalis = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblEvlilikDurum = new System.Windows.Forms.Label();
            this.lblYasBilgi = new System.Windows.Forms.Label();
            this.lblAdBilgi = new System.Windows.Forms.Label();
            this.lblEvlilikBilgi = new System.Windows.Forms.Label();
            this.lblSoyadBilgi = new System.Windows.Forms.Label();
            this.lblCalismaBilgi = new System.Windows.Forms.Label();
            this.lblCalismaSure = new System.Windows.Forms.Label();
            this.grpPersonelAra = new System.Windows.Forms.GroupBox();
            this.lblPersonelTCBilgi = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.uyariMesaji = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPersonelDosya.SuspendLayout();
            this.grpPersonelBilgi.SuspendLayout();
            this.grpMaasBilgi.SuspendLayout();
            this.grpDigerBilgi.SuspendLayout();
            this.grpKisiselBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelFotograf)).BeginInit();
            this.grpPersonelAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyariMesaji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Location = new System.Drawing.Point(716, 69);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(150, 49);
            this.btnDosyaAc.TabIndex = 0;
            this.btnDosyaAc.Text = "Dosya Aç";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Personel Listesi";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(143, 23);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(177, 20);
            this.txtKimlik.TabIndex = 2;
            this.txtKimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimlik_KeyPress);
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(350, 11);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(89, 44);
            this.btnPersonelAra.TabIndex = 3;
            this.btnPersonelAra.Text = "Personel Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // grpPersonelDosya
            // 
            this.grpPersonelDosya.Controls.Add(this.rTxtPersonelBilgi);
            this.grpPersonelDosya.Controls.Add(this.btnDosyaAc);
            this.grpPersonelDosya.Controls.Add(this.label1);
            this.grpPersonelDosya.Location = new System.Drawing.Point(12, 12);
            this.grpPersonelDosya.Name = "grpPersonelDosya";
            this.grpPersonelDosya.Size = new System.Drawing.Size(872, 153);
            this.grpPersonelDosya.TabIndex = 4;
            this.grpPersonelDosya.TabStop = false;
            this.grpPersonelDosya.Text = "Personel Dosyasý";
            // 
            // rTxtPersonelBilgi
            // 
            this.rTxtPersonelBilgi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTxtPersonelBilgi.DetectUrls = false;
            this.rTxtPersonelBilgi.Location = new System.Drawing.Point(6, 42);
            this.rTxtPersonelBilgi.Name = "rTxtPersonelBilgi";
            this.rTxtPersonelBilgi.ReadOnly = true;
            this.rTxtPersonelBilgi.Size = new System.Drawing.Size(704, 105);
            this.rTxtPersonelBilgi.TabIndex = 0;
            this.rTxtPersonelBilgi.Text = "";
            // 
            // grpPersonelBilgi
            // 
            this.grpPersonelBilgi.Controls.Add(this.grpMaasBilgi);
            this.grpPersonelBilgi.Controls.Add(this.grpDigerBilgi);
            this.grpPersonelBilgi.Controls.Add(this.grpKisiselBilgi);
            this.grpPersonelBilgi.Controls.Add(this.grpPersonelAra);
            this.grpPersonelBilgi.Location = new System.Drawing.Point(12, 171);
            this.grpPersonelBilgi.Name = "grpPersonelBilgi";
            this.grpPersonelBilgi.Size = new System.Drawing.Size(872, 242);
            this.grpPersonelBilgi.TabIndex = 5;
            this.grpPersonelBilgi.TabStop = false;
            this.grpPersonelBilgi.Text = "Personel Bilgileri";
            // 
            // grpMaasBilgi
            // 
            this.grpMaasBilgi.Controls.Add(this.lblNetMaas);
            this.grpMaasBilgi.Controls.Add(this.lblBrutMaas);
            this.grpMaasBilgi.Controls.Add(this.lblNetBilgi);
            this.grpMaasBilgi.Controls.Add(this.lblGelirBilgi);
            this.grpMaasBilgi.Controls.Add(this.lblEmekliKes);
            this.grpMaasBilgi.Controls.Add(this.lblGelirVergi);
            this.grpMaasBilgi.Controls.Add(this.lblDamgaBilgi);
            this.grpMaasBilgi.Controls.Add(this.lblBrutBilgi);
            this.grpMaasBilgi.Controls.Add(this.lblEmekBilgi);
            this.grpMaasBilgi.Controls.Add(this.lblDamgaVergi);
            this.grpMaasBilgi.Location = new System.Drawing.Point(460, 126);
            this.grpMaasBilgi.Name = "grpMaasBilgi";
            this.grpMaasBilgi.Size = new System.Drawing.Size(403, 109);
            this.grpMaasBilgi.TabIndex = 11;
            this.grpMaasBilgi.TabStop = false;
            this.grpMaasBilgi.Text = "Maaþ Bilgileri";
            // 
            // lblNetMaas
            // 
            this.lblNetMaas.AutoSize = true;
            this.lblNetMaas.Location = new System.Drawing.Point(201, 80);
            this.lblNetMaas.Name = "lblNetMaas";
            this.lblNetMaas.Size = new System.Drawing.Size(41, 13);
            this.lblNetMaas.TabIndex = 28;
            this.lblNetMaas.Text = "label36";
            // 
            // lblBrutMaas
            // 
            this.lblBrutMaas.AutoSize = true;
            this.lblBrutMaas.Location = new System.Drawing.Point(124, 25);
            this.lblBrutMaas.Name = "lblBrutMaas";
            this.lblBrutMaas.Size = new System.Drawing.Size(41, 13);
            this.lblBrutMaas.TabIndex = 23;
            this.lblBrutMaas.Text = "label28";
            // 
            // lblNetBilgi
            // 
            this.lblNetBilgi.AutoSize = true;
            this.lblNetBilgi.Location = new System.Drawing.Point(136, 80);
            this.lblNetBilgi.Name = "lblNetBilgi";
            this.lblNetBilgi.Size = new System.Drawing.Size(59, 13);
            this.lblNetBilgi.TabIndex = 29;
            this.lblNetBilgi.Text = "Net Maaþ :";
            // 
            // lblGelirBilgi
            // 
            this.lblGelirBilgi.AutoSize = true;
            this.lblGelirBilgi.Location = new System.Drawing.Point(217, 49);
            this.lblGelirBilgi.Name = "lblGelirBilgi";
            this.lblGelirBilgi.Size = new System.Drawing.Size(68, 13);
            this.lblGelirBilgi.TabIndex = 26;
            this.lblGelirBilgi.Text = "Gelir Vergisi :";
            // 
            // lblEmekliKes
            // 
            this.lblEmekliKes.AutoSize = true;
            this.lblEmekliKes.Location = new System.Drawing.Point(124, 49);
            this.lblEmekliKes.Name = "lblEmekliKes";
            this.lblEmekliKes.Size = new System.Drawing.Size(41, 13);
            this.lblEmekliKes.TabIndex = 25;
            this.lblEmekliKes.Text = "label31";
            // 
            // lblGelirVergi
            // 
            this.lblGelirVergi.AutoSize = true;
            this.lblGelirVergi.Location = new System.Drawing.Point(323, 49);
            this.lblGelirVergi.Name = "lblGelirVergi";
            this.lblGelirVergi.Size = new System.Drawing.Size(41, 13);
            this.lblGelirVergi.TabIndex = 21;
            this.lblGelirVergi.Text = "label34";
            // 
            // lblDamgaBilgi
            // 
            this.lblDamgaBilgi.AutoSize = true;
            this.lblDamgaBilgi.Location = new System.Drawing.Point(217, 25);
            this.lblDamgaBilgi.Name = "lblDamgaBilgi";
            this.lblDamgaBilgi.Size = new System.Drawing.Size(81, 13);
            this.lblDamgaBilgi.TabIndex = 28;
            this.lblDamgaBilgi.Text = "Damga Vergisi :";
            // 
            // lblBrutBilgi
            // 
            this.lblBrutBilgi.AutoSize = true;
            this.lblBrutBilgi.Location = new System.Drawing.Point(6, 25);
            this.lblBrutBilgi.Name = "lblBrutBilgi";
            this.lblBrutBilgi.Size = new System.Drawing.Size(61, 13);
            this.lblBrutBilgi.TabIndex = 22;
            this.lblBrutBilgi.Text = "Brüt Maaþ :";
            // 
            // lblEmekBilgi
            // 
            this.lblEmekBilgi.AutoSize = true;
            this.lblEmekBilgi.Location = new System.Drawing.Point(6, 49);
            this.lblEmekBilgi.Name = "lblEmekBilgi";
            this.lblEmekBilgi.Size = new System.Drawing.Size(85, 13);
            this.lblEmekBilgi.TabIndex = 27;
            this.lblEmekBilgi.Text = "Emekli Kesintisi :";
            // 
            // lblDamgaVergi
            // 
            this.lblDamgaVergi.AutoSize = true;
            this.lblDamgaVergi.Location = new System.Drawing.Point(323, 25);
            this.lblDamgaVergi.Name = "lblDamgaVergi";
            this.lblDamgaVergi.Size = new System.Drawing.Size(41, 13);
            this.lblDamgaVergi.TabIndex = 24;
            this.lblDamgaVergi.Text = "label30";
            // 
            // grpDigerBilgi
            // 
            this.grpDigerBilgi.Controls.Add(this.lblMesaiUcret);
            this.grpDigerBilgi.Controls.Add(this.lblMesai);
            this.grpDigerBilgi.Controls.Add(this.lblMesaiUcBilgi);
            this.grpDigerBilgi.Controls.Add(this.lblVergiMat);
            this.grpDigerBilgi.Controls.Add(this.lblVergiBilgi);
            this.grpDigerBilgi.Controls.Add(this.lblGorevTazminat);
            this.grpDigerBilgi.Controls.Add(this.lblMesaiBilgi);
            this.grpDigerBilgi.Controls.Add(this.lblMakTazminat);
            this.grpDigerBilgi.Controls.Add(this.lblGorTazBilgi);
            this.grpDigerBilgi.Controls.Add(this.lblMakTazBilgi);
            this.grpDigerBilgi.Controls.Add(this.lblTabanMaas);
            this.grpDigerBilgi.Controls.Add(this.lblTabanBilgi);
            this.grpDigerBilgi.Location = new System.Drawing.Point(459, 19);
            this.grpDigerBilgi.Name = "grpDigerBilgi";
            this.grpDigerBilgi.Size = new System.Drawing.Size(404, 101);
            this.grpDigerBilgi.TabIndex = 10;
            this.grpDigerBilgi.TabStop = false;
            this.grpDigerBilgi.Text = "Diðer Bilgiler";
            // 
            // lblMesaiUcret
            // 
            this.lblMesaiUcret.AutoSize = true;
            this.lblMesaiUcret.Location = new System.Drawing.Point(324, 76);
            this.lblMesaiUcret.Name = "lblMesaiUcret";
            this.lblMesaiUcret.Size = new System.Drawing.Size(41, 13);
            this.lblMesaiUcret.TabIndex = 19;
            this.lblMesaiUcret.Text = "label25";
            // 
            // lblMesai
            // 
            this.lblMesai.AutoSize = true;
            this.lblMesai.Location = new System.Drawing.Point(125, 76);
            this.lblMesai.Name = "lblMesai";
            this.lblMesai.Size = new System.Drawing.Size(41, 13);
            this.lblMesai.TabIndex = 21;
            this.lblMesai.Text = "label23";
            // 
            // lblMesaiUcBilgi
            // 
            this.lblMesaiUcBilgi.AutoSize = true;
            this.lblMesaiUcBilgi.Location = new System.Drawing.Point(218, 76);
            this.lblMesaiUcBilgi.Name = "lblMesaiUcBilgi";
            this.lblMesaiUcBilgi.Size = new System.Drawing.Size(100, 13);
            this.lblMesaiUcBilgi.TabIndex = 20;
            this.lblMesaiUcBilgi.Text = "Fazla Mesai Ücreti :";
            // 
            // lblVergiMat
            // 
            this.lblVergiMat.AutoSize = true;
            this.lblVergiMat.Location = new System.Drawing.Point(324, 48);
            this.lblVergiMat.Name = "lblVergiMat";
            this.lblVergiMat.Size = new System.Drawing.Size(41, 13);
            this.lblVergiMat.TabIndex = 19;
            this.lblVergiMat.Text = "label21";
            // 
            // lblVergiBilgi
            // 
            this.lblVergiBilgi.AutoSize = true;
            this.lblVergiBilgi.Location = new System.Drawing.Point(218, 48);
            this.lblVergiBilgi.Name = "lblVergiBilgi";
            this.lblVergiBilgi.Size = new System.Drawing.Size(75, 13);
            this.lblVergiBilgi.TabIndex = 20;
            this.lblVergiBilgi.Text = "Vergi Matrahý :";
            // 
            // lblGorevTazminat
            // 
            this.lblGorevTazminat.AutoSize = true;
            this.lblGorevTazminat.Location = new System.Drawing.Point(125, 48);
            this.lblGorevTazminat.Name = "lblGorevTazminat";
            this.lblGorevTazminat.Size = new System.Drawing.Size(41, 13);
            this.lblGorevTazminat.TabIndex = 19;
            this.lblGorevTazminat.Text = "label19";
            // 
            // lblMesaiBilgi
            // 
            this.lblMesaiBilgi.AutoSize = true;
            this.lblMesaiBilgi.Location = new System.Drawing.Point(6, 76);
            this.lblMesaiBilgi.Name = "lblMesaiBilgi";
            this.lblMesaiBilgi.Size = new System.Drawing.Size(96, 13);
            this.lblMesaiBilgi.TabIndex = 22;
            this.lblMesaiBilgi.Text = "Fazla Mesai Saati :";
            // 
            // lblMakTazminat
            // 
            this.lblMakTazminat.AutoSize = true;
            this.lblMakTazminat.Location = new System.Drawing.Point(324, 23);
            this.lblMakTazminat.Name = "lblMakTazminat";
            this.lblMakTazminat.Size = new System.Drawing.Size(41, 13);
            this.lblMakTazminat.TabIndex = 19;
            this.lblMakTazminat.Text = "label17";
            // 
            // lblGorTazBilgi
            // 
            this.lblGorTazBilgi.AutoSize = true;
            this.lblGorTazBilgi.Location = new System.Drawing.Point(6, 48);
            this.lblGorTazBilgi.Name = "lblGorTazBilgi";
            this.lblGorTazBilgi.Size = new System.Drawing.Size(113, 13);
            this.lblGorTazBilgi.TabIndex = 20;
            this.lblGorTazBilgi.Text = "Ýdari Görev Tazminatý :";
            // 
            // lblMakTazBilgi
            // 
            this.lblMakTazBilgi.AutoSize = true;
            this.lblMakTazBilgi.Location = new System.Drawing.Point(218, 22);
            this.lblMakTazBilgi.Name = "lblMakTazBilgi";
            this.lblMakTazBilgi.Size = new System.Drawing.Size(96, 13);
            this.lblMakTazBilgi.TabIndex = 20;
            this.lblMakTazBilgi.Text = "Makam Tazminatý :";
            // 
            // lblTabanMaas
            // 
            this.lblTabanMaas.AutoSize = true;
            this.lblTabanMaas.Location = new System.Drawing.Point(125, 22);
            this.lblTabanMaas.Name = "lblTabanMaas";
            this.lblTabanMaas.Size = new System.Drawing.Size(41, 13);
            this.lblTabanMaas.TabIndex = 18;
            this.lblTabanMaas.Text = "label16";
            // 
            // lblTabanBilgi
            // 
            this.lblTabanBilgi.AutoSize = true;
            this.lblTabanBilgi.Location = new System.Drawing.Point(6, 22);
            this.lblTabanBilgi.Name = "lblTabanBilgi";
            this.lblTabanBilgi.Size = new System.Drawing.Size(73, 13);
            this.lblTabanBilgi.TabIndex = 18;
            this.lblTabanBilgi.Text = "Taban Maaþ :";
            // 
            // grpKisiselBilgi
            // 
            this.grpKisiselBilgi.Controls.Add(this.lblCocukBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblCocukSa);
            this.grpKisiselBilgi.Controls.Add(this.lblTC);
            this.grpKisiselBilgi.Controls.Add(this.lblTCBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblEsBilgi);
            this.grpKisiselBilgi.Controls.Add(this.personelFotograf);
            this.grpKisiselBilgi.Controls.Add(this.label27);
            this.grpKisiselBilgi.Controls.Add(this.lblEsCalis);
            this.grpKisiselBilgi.Controls.Add(this.lblYas);
            this.grpKisiselBilgi.Controls.Add(this.lblSoyad);
            this.grpKisiselBilgi.Controls.Add(this.lblAd);
            this.grpKisiselBilgi.Controls.Add(this.lblEvlilikDurum);
            this.grpKisiselBilgi.Controls.Add(this.lblYasBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblAdBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblEvlilikBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblSoyadBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblCalismaBilgi);
            this.grpKisiselBilgi.Controls.Add(this.lblCalismaSure);
            this.grpKisiselBilgi.Location = new System.Drawing.Point(6, 86);
            this.grpKisiselBilgi.Name = "grpKisiselBilgi";
            this.grpKisiselBilgi.Size = new System.Drawing.Size(448, 149);
            this.grpKisiselBilgi.TabIndex = 7;
            this.grpKisiselBilgi.TabStop = false;
            this.grpKisiselBilgi.Text = "Kiþisel Bilgiler";
            // 
            // lblCocukBilgi
            // 
            this.lblCocukBilgi.AutoSize = true;
            this.lblCocukBilgi.Location = new System.Drawing.Point(155, 111);
            this.lblCocukBilgi.Name = "lblCocukBilgi";
            this.lblCocukBilgi.Size = new System.Drawing.Size(74, 13);
            this.lblCocukBilgi.TabIndex = 23;
            this.lblCocukBilgi.Text = "Çocuk Sayýsý :";
            // 
            // lblCocukSa
            // 
            this.lblCocukSa.AutoSize = true;
            this.lblCocukSa.Location = new System.Drawing.Point(242, 111);
            this.lblCocukSa.Name = "lblCocukSa";
            this.lblCocukSa.Size = new System.Drawing.Size(41, 13);
            this.lblCocukSa.TabIndex = 22;
            this.lblCocukSa.Text = "label41";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(60, 40);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(41, 13);
            this.lblTC.TabIndex = 21;
            this.lblTC.Text = "label38";
            // 
            // lblTCBilgi
            // 
            this.lblTCBilgi.AutoSize = true;
            this.lblTCBilgi.Location = new System.Drawing.Point(9, 42);
            this.lblTCBilgi.Name = "lblTCBilgi";
            this.lblTCBilgi.Size = new System.Drawing.Size(27, 13);
            this.lblTCBilgi.TabIndex = 20;
            this.lblTCBilgi.Text = "TC :";
            // 
            // lblEsBilgi
            // 
            this.lblEsBilgi.AutoSize = true;
            this.lblEsBilgi.Location = new System.Drawing.Point(155, 89);
            this.lblEsBilgi.Name = "lblEsBilgi";
            this.lblEsBilgi.Size = new System.Drawing.Size(85, 13);
            this.lblEsBilgi.TabIndex = 13;
            this.lblEsBilgi.Text = "Eþi Çalýþýyor mu :";
            // 
            // personelFotograf
            // 
            this.personelFotograf.Location = new System.Drawing.Point(301, 40);
            this.personelFotograf.Name = "personelFotograf";
            this.personelFotograf.Size = new System.Drawing.Size(122, 103);
            this.personelFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personelFotograf.TabIndex = 19;
            this.personelFotograf.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(337, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "Fotoðraf";
            // 
            // lblEsCalis
            // 
            this.lblEsCalis.AutoSize = true;
            this.lblEsCalis.Location = new System.Drawing.Point(242, 89);
            this.lblEsCalis.Name = "lblEsCalis";
            this.lblEsCalis.Size = new System.Drawing.Size(41, 13);
            this.lblEsCalis.TabIndex = 12;
            this.lblEsCalis.Text = "label14";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(60, 111);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(35, 13);
            this.lblYas.TabIndex = 9;
            this.lblYas.Text = "label8";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(60, 89);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "label7";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(60, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 13);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "label6";
            // 
            // lblEvlilikDurum
            // 
            this.lblEvlilikDurum.AutoSize = true;
            this.lblEvlilikDurum.Location = new System.Drawing.Point(242, 65);
            this.lblEvlilikDurum.Name = "lblEvlilikDurum";
            this.lblEvlilikDurum.Size = new System.Drawing.Size(41, 13);
            this.lblEvlilikDurum.TabIndex = 14;
            this.lblEvlilikDurum.Text = "label12";
            // 
            // lblYasBilgi
            // 
            this.lblYasBilgi.AutoSize = true;
            this.lblYasBilgi.Location = new System.Drawing.Point(9, 111);
            this.lblYasBilgi.Name = "lblYasBilgi";
            this.lblYasBilgi.Size = new System.Drawing.Size(31, 13);
            this.lblYasBilgi.TabIndex = 8;
            this.lblYasBilgi.Text = "Yaþ :";
            // 
            // lblAdBilgi
            // 
            this.lblAdBilgi.AutoSize = true;
            this.lblAdBilgi.Location = new System.Drawing.Point(9, 65);
            this.lblAdBilgi.Name = "lblAdBilgi";
            this.lblAdBilgi.Size = new System.Drawing.Size(29, 13);
            this.lblAdBilgi.TabIndex = 5;
            this.lblAdBilgi.Text = "Ad : ";
            // 
            // lblEvlilikBilgi
            // 
            this.lblEvlilikBilgi.AutoSize = true;
            this.lblEvlilikBilgi.Location = new System.Drawing.Point(155, 65);
            this.lblEvlilikBilgi.Name = "lblEvlilikBilgi";
            this.lblEvlilikBilgi.Size = new System.Drawing.Size(83, 13);
            this.lblEvlilikBilgi.TabIndex = 15;
            this.lblEvlilikBilgi.Text = "Evlilik Durumu : ";
            // 
            // lblSoyadBilgi
            // 
            this.lblSoyadBilgi.AutoSize = true;
            this.lblSoyadBilgi.Location = new System.Drawing.Point(6, 89);
            this.lblSoyadBilgi.Name = "lblSoyadBilgi";
            this.lblSoyadBilgi.Size = new System.Drawing.Size(43, 13);
            this.lblSoyadBilgi.TabIndex = 6;
            this.lblSoyadBilgi.Text = "Soyad :";
            // 
            // lblCalismaBilgi
            // 
            this.lblCalismaBilgi.AutoSize = true;
            this.lblCalismaBilgi.Location = new System.Drawing.Point(155, 42);
            this.lblCalismaBilgi.Name = "lblCalismaBilgi";
            this.lblCalismaBilgi.Size = new System.Drawing.Size(81, 13);
            this.lblCalismaBilgi.TabIndex = 17;
            this.lblCalismaBilgi.Text = "Çalýþma Süresi :";
            // 
            // lblCalismaSure
            // 
            this.lblCalismaSure.AutoSize = true;
            this.lblCalismaSure.Location = new System.Drawing.Point(242, 42);
            this.lblCalismaSure.Name = "lblCalismaSure";
            this.lblCalismaSure.Size = new System.Drawing.Size(41, 13);
            this.lblCalismaSure.TabIndex = 16;
            this.lblCalismaSure.Text = "label10";
            // 
            // grpPersonelAra
            // 
            this.grpPersonelAra.Controls.Add(this.lblPersonelTCBilgi);
            this.grpPersonelAra.Controls.Add(this.btnPersonelAra);
            this.grpPersonelAra.Controls.Add(this.txtKimlik);
            this.grpPersonelAra.Location = new System.Drawing.Point(9, 19);
            this.grpPersonelAra.Name = "grpPersonelAra";
            this.grpPersonelAra.Size = new System.Drawing.Size(445, 61);
            this.grpPersonelAra.TabIndex = 4;
            this.grpPersonelAra.TabStop = false;
            this.grpPersonelAra.Text = "Personel Ara";
            // 
            // lblPersonelTCBilgi
            // 
            this.lblPersonelTCBilgi.AutoSize = true;
            this.lblPersonelTCBilgi.Location = new System.Drawing.Point(6, 26);
            this.lblPersonelTCBilgi.Name = "lblPersonelTCBilgi";
            this.lblPersonelTCBilgi.Size = new System.Drawing.Size(131, 13);
            this.lblPersonelTCBilgi.TabIndex = 5;
            this.lblPersonelTCBilgi.Text = "Personel Kimlik Numarasý :";
            // 
            // uyariMesaji
            // 
            this.uyariMesaji.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 419);
            this.Controls.Add(this.grpPersonelBilgi);
            this.Controls.Add(this.grpPersonelDosya);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Maaþ Hesaplama Programý";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonelDosya.ResumeLayout(false);
            this.grpPersonelDosya.PerformLayout();
            this.grpPersonelBilgi.ResumeLayout(false);
            this.grpMaasBilgi.ResumeLayout(false);
            this.grpMaasBilgi.PerformLayout();
            this.grpDigerBilgi.ResumeLayout(false);
            this.grpDigerBilgi.PerformLayout();
            this.grpKisiselBilgi.ResumeLayout(false);
            this.grpKisiselBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelFotograf)).EndInit();
            this.grpPersonelAra.ResumeLayout(false);
            this.grpPersonelAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyariMesaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.GroupBox grpPersonelDosya;
        private System.Windows.Forms.GroupBox grpPersonelBilgi;
        private System.Windows.Forms.GroupBox grpPersonelAra;
        private System.Windows.Forms.Label lblPersonelTCBilgi;
        private System.Windows.Forms.Label lblAdBilgi;
        private System.Windows.Forms.GroupBox grpKisiselBilgi;
        private System.Windows.Forms.Label lblSoyadBilgi;
        private System.Windows.Forms.Label lblYasBilgi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grpDigerBilgi;
        private System.Windows.Forms.Label lblVergiMat;
        private System.Windows.Forms.Label lblGorevTazminat;
        private System.Windows.Forms.Label lblVergiBilgi;
        private System.Windows.Forms.Label lblMakTazminat;
        private System.Windows.Forms.Label lblGorTazBilgi;
        private System.Windows.Forms.Label lblMakTazBilgi;
        private System.Windows.Forms.Label lblTabanMaas;
        private System.Windows.Forms.Label lblTabanBilgi;
        private System.Windows.Forms.Label lblEsCalis;
        private System.Windows.Forms.Label lblEsBilgi;
        private System.Windows.Forms.Label lblEvlilikDurum;
        private System.Windows.Forms.Label lblEvlilikBilgi;
        private System.Windows.Forms.Label lblCalismaSure;
        private System.Windows.Forms.Label lblCalismaBilgi;
        private System.Windows.Forms.Label lblMesaiUcret;
        private System.Windows.Forms.Label lblMesai;
        private System.Windows.Forms.Label lblMesaiUcBilgi;
        private System.Windows.Forms.Label lblMesaiBilgi;
        private System.Windows.Forms.GroupBox grpMaasBilgi;
        private System.Windows.Forms.Label lblNetMaas;
        private System.Windows.Forms.Label lblBrutMaas;
        private System.Windows.Forms.Label lblNetBilgi;
        private System.Windows.Forms.Label lblGelirBilgi;
        private System.Windows.Forms.Label lblEmekliKes;
        private System.Windows.Forms.Label lblGelirVergi;
        private System.Windows.Forms.Label lblDamgaBilgi;
        private System.Windows.Forms.Label lblBrutBilgi;
        private System.Windows.Forms.Label lblEmekBilgi;
        private System.Windows.Forms.Label lblDamgaVergi;
        private System.Windows.Forms.PictureBox personelFotograf;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblCocukBilgi;
        private System.Windows.Forms.Label lblCocukSa;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTCBilgi;
        private System.Windows.Forms.ErrorProvider uyariMesaji;
        private System.Windows.Forms.RichTextBox rTxtPersonelBilgi;
    }
}

