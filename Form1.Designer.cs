namespace EntityPersonel1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.entityPersonelDataSet = new EntityPersonel1.EntityPersonelDataSet();
            this.viewPersonelBirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPersonelBirimTableAdapter = new EntityPersonel1.EntityPersonelDataSetTableAdapters.viewPersonelBirimTableAdapter();
            this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.birimAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnYeni = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityPersonelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonelBirimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelID,
            this.BirimAdi,
            this.AdiSoyadi,
            this.Telefon,
            this.Adres,
            this.Email,
            this.Tarih,
            this.IsActive,
            this.personelIDDataGridViewTextBoxColumn,
            this.birimIDDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewImageColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.ısActiveDataGridViewCheckBoxColumn,
            this.birimAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPersonelBirimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(104, 9);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // entityPersonelDataSet
            // 
            this.entityPersonelDataSet.DataSetName = "EntityPersonelDataSet";
            this.entityPersonelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPersonelBirimBindingSource
            // 
            this.viewPersonelBirimBindingSource.DataMember = "viewPersonelBirim";
            this.viewPersonelBirimBindingSource.DataSource = this.entityPersonelDataSet;
            // 
            // viewPersonelBirimTableAdapter
            // 
            this.viewPersonelBirimTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelID
            // 
            this.PersonelID.DataPropertyName = "PersonelID";
            this.PersonelID.HeaderText = "Personel ID";
            this.PersonelID.MinimumWidth = 6;
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Width = 125;
            // 
            // BirimAdi
            // 
            this.BirimAdi.DataPropertyName = "BirimAdi";
            this.BirimAdi.HeaderText = "Birim ";
            this.BirimAdi.MinimumWidth = 6;
            this.BirimAdi.Name = "BirimAdi";
            this.BirimAdi.Width = 125;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DataPropertyName = "AdiSoyadi";
            this.AdiSoyadi.HeaderText = "Adı Soyadı";
            this.AdiSoyadi.MinimumWidth = 6;
            this.AdiSoyadi.Name = "AdiSoyadi";
            this.AdiSoyadi.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 125;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.MinimumWidth = 6;
            this.Adres.Name = "Adres";
            this.Adres.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 125;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = false;
            this.IsActive.Width = 125;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(93, 289);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelAdSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 378);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aktif mi";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(93, 261);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Personel ID";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 350);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 15;
            this.txtTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefon";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(358, 317);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(272, 63);
            this.txtAdres.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Adres";
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimIDDataGridViewTextBoxColumn
            // 
            this.birimIDDataGridViewTextBoxColumn.DataPropertyName = "BirimID";
            this.birimIDDataGridViewTextBoxColumn.HeaderText = "BirimID";
            this.birimIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimIDDataGridViewTextBoxColumn.Name = "birimIDDataGridViewTextBoxColumn";
            this.birimIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            this.adiSoyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewImageColumn
            // 
            this.emailDataGridViewImageColumn.DataPropertyName = "Email";
            this.emailDataGridViewImageColumn.HeaderText = "Email";
            this.emailDataGridViewImageColumn.MinimumWidth = 6;
            this.emailDataGridViewImageColumn.Name = "emailDataGridViewImageColumn";
            this.emailDataGridViewImageColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısActiveDataGridViewCheckBoxColumn
            // 
            this.ısActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.ısActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.ısActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısActiveDataGridViewCheckBoxColumn.Name = "ısActiveDataGridViewCheckBoxColumn";
            this.ısActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // birimAdiDataGridViewTextBoxColumn
            // 
            this.birimAdiDataGridViewTextBoxColumn.DataPropertyName = "BirimAdi";
            this.birimAdiDataGridViewTextBoxColumn.HeaderText = "BirimAdi";
            this.birimAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimAdiDataGridViewTextBoxColumn.Name = "birimAdiDataGridViewTextBoxColumn";
            this.birimAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // BtnYeni
            // 
            this.BtnYeni.Location = new System.Drawing.Point(358, 386);
            this.BtnYeni.Name = "BtnYeni";
            this.BtnYeni.Size = new System.Drawing.Size(76, 42);
            this.BtnYeni.TabIndex = 19;
            this.BtnYeni.Text = "Yeni";
            this.BtnYeni.UseVisualStyleBackColor = true;
            this.BtnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(439, 386);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(76, 42);
            this.BtnKaydet.TabIndex = 20;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(520, 386);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(76, 42);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "BirimAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "BirimID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 484);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnYeni);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.label3_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityPersonelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonelBirimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private EntityPersonelDataSet entityPersonelDataSet;
        private System.Windows.Forms.BindingSource viewPersonelBirimBindingSource;
        private EntityPersonelDataSetTableAdapters.viewPersonelBirimTableAdapter viewPersonelBirimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn emailDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnYeni;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

