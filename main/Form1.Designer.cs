namespace main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtArama = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAd = new Guna.UI2.WinForms.Guna2Button();
            this.btnTelefon = new Guna.UI2.WinForms.Guna2Button();
            this.txtAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSoyad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNumara = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncel = new Guna.UI2.WinForms.Guna2Button();
            this.btnListele = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboSecim = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.BorderColorFocused = System.Drawing.Color.Lime;
            this.txtArama.BorderColorIdle = System.Drawing.Color.White;
            this.txtArama.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtArama.BorderThickness = 3;
            this.txtArama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.ForeColor = System.Drawing.Color.White;
            this.txtArama.isPassword = false;
            this.txtArama.Location = new System.Drawing.Point(55, 29);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(346, 56);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtArama.Enter += new System.EventHandler(this.txtArama_Enter);
            this.txtArama.Leave += new System.EventHandler(this.txtArama_Leave);
            // 
            // btnAd
            // 
            this.btnAd.BorderColor = System.Drawing.Color.White;
            this.btnAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAd.CustomBorderColor = System.Drawing.Color.White;
            this.btnAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnAd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAd.ForeColor = System.Drawing.Color.White;
            this.btnAd.Location = new System.Drawing.Point(75, 103);
            this.btnAd.Name = "btnAd";
            this.btnAd.PressedColor = System.Drawing.Color.White;
            this.btnAd.Size = new System.Drawing.Size(132, 50);
            this.btnAd.TabIndex = 1;
            this.btnAd.Text = "Ad ile Ara";
            this.btnAd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnTelefon
            // 
            this.btnTelefon.BorderColor = System.Drawing.Color.White;
            this.btnTelefon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefon.CustomBorderColor = System.Drawing.Color.White;
            this.btnTelefon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTelefon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTelefon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTelefon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTelefon.ForeColor = System.Drawing.Color.White;
            this.btnTelefon.Location = new System.Drawing.Point(246, 103);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.PressedColor = System.Drawing.Color.White;
            this.btnTelefon.Size = new System.Drawing.Size(132, 50);
            this.btnTelefon.TabIndex = 2;
            this.btnTelefon.Text = "Telefon İle Ara";
            this.btnTelefon.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
            // 
            // txtAd
            // 
            this.txtAd.BorderColorFocused = System.Drawing.Color.Lime;
            this.txtAd.BorderColorIdle = System.Drawing.Color.White;
            this.txtAd.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtAd.BorderThickness = 3;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.isPassword = false;
            this.txtAd.Location = new System.Drawing.Point(55, 179);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(346, 56);
            this.txtAd.TabIndex = 3;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderColorFocused = System.Drawing.Color.Lime;
            this.txtSoyad.BorderColorIdle = System.Drawing.Color.White;
            this.txtSoyad.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtSoyad.BorderThickness = 3;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.isPassword = false;
            this.txtSoyad.Location = new System.Drawing.Point(55, 245);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(346, 56);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoyad.Enter += new System.EventHandler(this.txtSoyad_Enter);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // txtNumara
            // 
            this.txtNumara.BorderColorFocused = System.Drawing.Color.Lime;
            this.txtNumara.BorderColorIdle = System.Drawing.Color.White;
            this.txtNumara.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.txtNumara.BorderThickness = 3;
            this.txtNumara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumara.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.ForeColor = System.Drawing.Color.White;
            this.txtNumara.isPassword = false;
            this.txtNumara.Location = new System.Drawing.Point(55, 311);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(346, 56);
            this.txtNumara.TabIndex = 5;
            this.txtNumara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumara.Enter += new System.EventHandler(this.txtNumara_Enter);
            this.txtNumara.Leave += new System.EventHandler(this.txtNumara_Leave);
            // 
            // btnSil
            // 
            this.btnSil.BorderColor = System.Drawing.Color.White;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.CustomBorderColor = System.Drawing.Color.White;
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSil.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(246, 474);
            this.btnSil.Name = "btnSil";
            this.btnSil.PressedColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(132, 50);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderColor = System.Drawing.Color.White;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.CustomBorderColor = System.Drawing.Color.White;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(75, 474);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PressedColor = System.Drawing.Color.White;
            this.btnEkle.Size = new System.Drawing.Size(132, 50);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.BorderColor = System.Drawing.Color.White;
            this.btnGuncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncel.CustomBorderColor = System.Drawing.Color.White;
            this.btnGuncel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnGuncel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncel.ForeColor = System.Drawing.Color.White;
            this.btnGuncel.Location = new System.Drawing.Point(246, 563);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.PressedColor = System.Drawing.Color.White;
            this.btnGuncel.Size = new System.Drawing.Size(132, 50);
            this.btnGuncel.TabIndex = 9;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnListele
            // 
            this.btnListele.BorderColor = System.Drawing.Color.White;
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.CustomBorderColor = System.Drawing.Color.White;
            this.btnListele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListele.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnListele.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(75, 563);
            this.btnListele.Name = "btnListele";
            this.btnListele.PressedColor = System.Drawing.Color.White;
            this.btnListele.Size = new System.Drawing.Size(132, 50);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.Location = new System.Drawing.Point(486, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(531, 643);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // comboSecim
            // 
            this.comboSecim.BackColor = System.Drawing.Color.Transparent;
            this.comboSecim.BorderColor = System.Drawing.Color.White;
            this.comboSecim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSecim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboSecim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSecim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSecim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSecim.ForeColor = System.Drawing.Color.White;
            this.comboSecim.ItemHeight = 30;
            this.comboSecim.Items.AddRange(new object[] {
            "GSM",
            "Sabit Telefon"});
            this.comboSecim.Location = new System.Drawing.Point(131, 403);
            this.comboSecim.Name = "comboSecim";
            this.comboSecim.Size = new System.Drawing.Size(192, 36);
            this.comboSecim.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1017, 643);
            this.Controls.Add(this.comboSecim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnTelefon);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.txtArama);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtArama;
        private Guna.UI2.WinForms.Guna2Button btnAd;
        private Guna.UI2.WinForms.Guna2Button btnTelefon;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoyad;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNumara;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnGuncel;
        private Guna.UI2.WinForms.Guna2Button btnListele;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox comboSecim;
    }
}

