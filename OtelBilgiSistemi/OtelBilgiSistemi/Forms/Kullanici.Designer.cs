namespace OtelBilgiSistemi.Forms
{
    partial class Kullanici
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AraBtn = new MetroFramework.Controls.MetroButton();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lw_otelListesi = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.Oteltxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Adabtn = new MetroFramework.Controls.MetroButton();
            this.Sehirbtn = new MetroFramework.Controls.MetroButton();
            this.yıldızbtn = new MetroFramework.Controls.MetroButton();
            this.metroComboBox5 = new MetroFramework.Controls.MetroComboBox();
            this.IkılıAramabtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(535, 122);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 20);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Yıldız";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(382, 122);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 20);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "İlçe";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(212, 122);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Şehir";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.Visible = false;
            // 
            // AraBtn
            // 
            this.AraBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AraBtn.Location = new System.Drawing.Point(808, 155);
            this.AraBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(152, 30);
            this.AraBtn.TabIndex = 14;
            this.AraBtn.Text = "Ara";
            this.AraBtn.UseSelectable = true;
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 24;
            this.metroComboBox3.Location = new System.Drawing.Point(357, 154);
            this.metroComboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(145, 30);
            this.metroComboBox3.TabIndex = 12;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.Visible = false;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Antalya",
            "İzmir",
            "Muğla",
            "Mersin",
            "Adana",
            "İstanbul",
            "Gaziantep"});
            this.metroComboBox2.Location = new System.Drawing.Point(189, 154);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(160, 30);
            this.metroComboBox2.TabIndex = 11;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.Visible = false;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.metroComboBox1.Location = new System.Drawing.Point(510, 154);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(119, 30);
            this.metroComboBox1.TabIndex = 10;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // lw_otelListesi
            // 
            this.lw_otelListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lw_otelListesi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lw_otelListesi.FullRowSelect = true;
            this.lw_otelListesi.GridLines = true;
            this.lw_otelListesi.Location = new System.Drawing.Point(36, 198);
            this.lw_otelListesi.Name = "lw_otelListesi";
            this.lw_otelListesi.OwnerDraw = true;
            this.lw_otelListesi.Size = new System.Drawing.Size(938, 184);
            this.lw_otelListesi.TabIndex = 20;
            this.lw_otelListesi.UseCompatibleStateImageBehavior = false;
            this.lw_otelListesi.UseSelectable = true;
            this.lw_otelListesi.View = System.Windows.Forms.View.Details;
            this.lw_otelListesi.SelectedIndexChanged += new System.EventHandler(this.lw_otelListesi_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Otel Bilgileri";
            this.columnHeader5.Width = 688;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(111, 111);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(37, 424);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(392, 113);
            this.metroTextBox1.TabIndex = 21;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 24;
            this.metroComboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.metroComboBox4.Location = new System.Drawing.Point(595, 455);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(210, 30);
            this.metroComboBox4.TabIndex = 22;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(662, 424);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Otel Puanla";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(662, 506);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 23);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Gönder";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(191, 392);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 20);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Yorum Yaz";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(184, 556);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(80, 23);
            this.metroButton2.TabIndex = 26;
            this.metroButton2.Text = "Gönder";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(-16, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(985, 541);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(10, 28);
            this.txtId.TabIndex = 27;
            this.txtId.UseSelectable = true;
            this.txtId.Visible = false;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Oteltxt
            // 
            // 
            // 
            // 
            this.Oteltxt.CustomButton.Image = null;
            this.Oteltxt.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.Oteltxt.CustomButton.Name = "";
            this.Oteltxt.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.Oteltxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Oteltxt.CustomButton.TabIndex = 1;
            this.Oteltxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Oteltxt.CustomButton.UseSelectable = true;
            this.Oteltxt.CustomButton.Visible = false;
            this.Oteltxt.Lines = new string[0];
            this.Oteltxt.Location = new System.Drawing.Point(36, 154);
            this.Oteltxt.MaxLength = 32767;
            this.Oteltxt.Multiline = true;
            this.Oteltxt.Name = "Oteltxt";
            this.Oteltxt.PasswordChar = '\0';
            this.Oteltxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Oteltxt.SelectedText = "";
            this.Oteltxt.SelectionLength = 0;
            this.Oteltxt.SelectionStart = 0;
            this.Oteltxt.ShortcutsEnabled = true;
            this.Oteltxt.Size = new System.Drawing.Size(146, 31);
            this.Oteltxt.TabIndex = 28;
            this.Oteltxt.UseSelectable = true;
            this.Oteltxt.Visible = false;
            this.Oteltxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Oteltxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 122);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 20);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "İsim";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.Visible = false;
            // 
            // Adabtn
            // 
            this.Adabtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Adabtn.Location = new System.Drawing.Point(36, 82);
            this.Adabtn.Margin = new System.Windows.Forms.Padding(4);
            this.Adabtn.Name = "Adabtn";
            this.Adabtn.Size = new System.Drawing.Size(152, 36);
            this.Adabtn.TabIndex = 30;
            this.Adabtn.Text = "Ada Göre Sırala";
            this.Adabtn.UseSelectable = true;
            this.Adabtn.Click += new System.EventHandler(this.Adabtn_Click);
            // 
            // Sehirbtn
            // 
            this.Sehirbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Sehirbtn.Location = new System.Drawing.Point(198, 82);
            this.Sehirbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Sehirbtn.Name = "Sehirbtn";
            this.Sehirbtn.Size = new System.Drawing.Size(152, 36);
            this.Sehirbtn.TabIndex = 31;
            this.Sehirbtn.Text = "Sehir veya İlçe Ara";
            this.Sehirbtn.UseSelectable = true;
            this.Sehirbtn.Click += new System.EventHandler(this.Sehirbtn_Click);
            // 
            // yıldızbtn
            // 
            this.yıldızbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.yıldızbtn.Location = new System.Drawing.Point(359, 82);
            this.yıldızbtn.Margin = new System.Windows.Forms.Padding(4);
            this.yıldızbtn.Name = "yıldızbtn";
            this.yıldızbtn.Size = new System.Drawing.Size(137, 36);
            this.yıldızbtn.TabIndex = 32;
            this.yıldızbtn.Text = "Yıldız Sayisi";
            this.yıldızbtn.UseSelectable = true;
            this.yıldızbtn.Click += new System.EventHandler(this.yıldızbtn_Click);
            // 
            // metroComboBox5
            // 
            this.metroComboBox5.FormattingEnabled = true;
            this.metroComboBox5.ItemHeight = 24;
            this.metroComboBox5.Items.AddRange(new object[] {
            "Inorder",
            "Preorder",
            "Postorder"});
            this.metroComboBox5.Location = new System.Drawing.Point(637, 154);
            this.metroComboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBox5.Name = "metroComboBox5";
            this.metroComboBox5.Size = new System.Drawing.Size(153, 30);
            this.metroComboBox5.TabIndex = 33;
            this.metroComboBox5.UseSelectable = true;
            this.metroComboBox5.Visible = false;
            this.metroComboBox5.SelectedIndexChanged += new System.EventHandler(this.metroComboBox5_SelectedIndexChanged);
            // 
            // IkılıAramabtn
            // 
            this.IkılıAramabtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.IkılıAramabtn.Location = new System.Drawing.Point(659, 82);
            this.IkılıAramabtn.Margin = new System.Windows.Forms.Padding(4);
            this.IkılıAramabtn.Name = "IkılıAramabtn";
            this.IkılıAramabtn.Size = new System.Drawing.Size(137, 36);
            this.IkılıAramabtn.TabIndex = 34;
            this.IkılıAramabtn.Text = "Ikili Arama";
            this.IkılıAramabtn.UseSelectable = true;
            this.IkılıAramabtn.Click += new System.EventHandler(this.IkılıAramabtn_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(662, 122);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Ikılı Arama";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(808, 154);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(152, 30);
            this.metroButton3.TabIndex = 36;
            this.metroButton3.Text = "Ara";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Visible = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(508, 82);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(137, 36);
            this.metroButton4.TabIndex = 37;
            this.metroButton4.Text = "Yıldıza Göre Sırala";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.Location = new System.Drawing.Point(807, 154);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(152, 30);
            this.metroButton5.TabIndex = 38;
            this.metroButton5.Text = "Ara";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Visible = false;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.Location = new System.Drawing.Point(807, 82);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(151, 36);
            this.metroButton6.TabIndex = 39;
            this.metroButton6.Text = "Puan Listele";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton7.Location = new System.Drawing.Point(808, 155);
            this.metroButton7.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(152, 30);
            this.metroButton7.TabIndex = 40;
            this.metroButton7.Text = "Ara";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Visible = false;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 592);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.IkılıAramabtn);
            this.Controls.Add(this.metroComboBox5);
            this.Controls.Add(this.yıldızbtn);
            this.Controls.Add(this.Sehirbtn);
            this.Controls.Add(this.Adabtn);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Oteltxt);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox4);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lw_otelListesi);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.AraBtn);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton AraBtn;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroListView lw_otelListesi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox Oteltxt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton Adabtn;
        private MetroFramework.Controls.MetroButton Sehirbtn;
        private MetroFramework.Controls.MetroButton yıldızbtn;
        private MetroFramework.Controls.MetroComboBox metroComboBox5;
        private MetroFramework.Controls.MetroButton IkılıAramabtn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
    }
}