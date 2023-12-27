
namespace Vtys_Proje
{
    partial class UC_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kullanıcıAdı_textBox = new System.Windows.Forms.TextBox();
            this.kullanıcıAdı_label = new System.Windows.Forms.Label();
            this.kullanıcıSeviye_label = new System.Windows.Forms.Label();
            this.kullanıcıSeviye_comboBox = new System.Windows.Forms.ComboBox();
            this.kullanıcıID_label = new System.Windows.Forms.Label();
            this.kullanıcıID_textBox = new System.Windows.Forms.TextBox();
            this.kullanıcıOlustur_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.listele_Button = new System.Windows.Forms.Button();
            this.admin_dataGridView = new System.Windows.Forms.DataGridView();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSeviyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vtys_projeDataSet = new Vtys_Proje.vtys_projeDataSet();
            this.kullaniciTableAdapter = new Vtys_Proje.vtys_projeDataSetTableAdapters.KullaniciTableAdapter();
            this.userLevelBilgi_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admin_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanıcıAdı_textBox
            // 
            this.kullanıcıAdı_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdı_textBox.Location = new System.Drawing.Point(270, 111);
            this.kullanıcıAdı_textBox.Name = "kullanıcıAdı_textBox";
            this.kullanıcıAdı_textBox.Size = new System.Drawing.Size(166, 26);
            this.kullanıcıAdı_textBox.TabIndex = 8;
            // 
            // kullanıcıAdı_label
            // 
            this.kullanıcıAdı_label.AutoSize = true;
            this.kullanıcıAdı_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdı_label.Location = new System.Drawing.Point(29, 108);
            this.kullanıcıAdı_label.Name = "kullanıcıAdı_label";
            this.kullanıcıAdı_label.Size = new System.Drawing.Size(160, 29);
            this.kullanıcıAdı_label.TabIndex = 7;
            this.kullanıcıAdı_label.Text = "Kullanıcı Adı:";
            // 
            // kullanıcıSeviye_label
            // 
            this.kullanıcıSeviye_label.AutoSize = true;
            this.kullanıcıSeviye_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıSeviye_label.Location = new System.Drawing.Point(29, 169);
            this.kullanıcıSeviye_label.Name = "kullanıcıSeviye_label";
            this.kullanıcıSeviye_label.Size = new System.Drawing.Size(219, 29);
            this.kullanıcıSeviye_label.TabIndex = 7;
            this.kullanıcıSeviye_label.Text = "Kullanıcı Seviyesi:";
            // 
            // kullanıcıSeviye_comboBox
            // 
            this.kullanıcıSeviye_comboBox.FormattingEnabled = true;
            this.kullanıcıSeviye_comboBox.Items.AddRange(new object[] {
            "User1",
            "User2",
            "User3",
            "User4",
            "Admin"});
            this.kullanıcıSeviye_comboBox.Location = new System.Drawing.Point(270, 177);
            this.kullanıcıSeviye_comboBox.Name = "kullanıcıSeviye_comboBox";
            this.kullanıcıSeviye_comboBox.Size = new System.Drawing.Size(166, 24);
            this.kullanıcıSeviye_comboBox.TabIndex = 9;
            // 
            // kullanıcıID_label
            // 
            this.kullanıcıID_label.AutoSize = true;
            this.kullanıcıID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıID_label.Location = new System.Drawing.Point(29, 48);
            this.kullanıcıID_label.Name = "kullanıcıID_label";
            this.kullanıcıID_label.Size = new System.Drawing.Size(147, 29);
            this.kullanıcıID_label.TabIndex = 7;
            this.kullanıcıID_label.Text = "Kullanıcı ID:";
            // 
            // kullanıcıID_textBox
            // 
            this.kullanıcıID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıID_textBox.Location = new System.Drawing.Point(270, 53);
            this.kullanıcıID_textBox.Name = "kullanıcıID_textBox";
            this.kullanıcıID_textBox.Size = new System.Drawing.Size(166, 26);
            this.kullanıcıID_textBox.TabIndex = 8;
            // 
            // kullanıcıOlustur_button
            // 
            this.kullanıcıOlustur_button.Location = new System.Drawing.Point(304, 247);
            this.kullanıcıOlustur_button.Name = "kullanıcıOlustur_button";
            this.kullanıcıOlustur_button.Size = new System.Drawing.Size(132, 23);
            this.kullanıcıOlustur_button.TabIndex = 19;
            this.kullanıcıOlustur_button.Text = "Kullanıcı Oluştur";
            this.kullanıcıOlustur_button.UseVisualStyleBackColor = true;
            this.kullanıcıOlustur_button.Click += new System.EventHandler(this.kullanıcıOlustur_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Location = new System.Drawing.Point(186, 247);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(93, 23);
            this.guncelle_button.TabIndex = 19;
            this.guncelle_button.Text = "Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // listele_Button
            // 
            this.listele_Button.Location = new System.Drawing.Point(68, 247);
            this.listele_Button.Name = "listele_Button";
            this.listele_Button.Size = new System.Drawing.Size(81, 23);
            this.listele_Button.TabIndex = 19;
            this.listele_Button.Text = "Listele";
            this.listele_Button.UseVisualStyleBackColor = true;
            this.listele_Button.Click += new System.EventHandler(this.listele_Button_Click);
            // 
            // admin_dataGridView
            // 
            this.admin_dataGridView.AutoGenerateColumns = false;
            this.admin_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.kullaniciSeviyesiDataGridViewTextBoxColumn});
            this.admin_dataGridView.DataSource = this.kullaniciBindingSource;
            this.admin_dataGridView.Location = new System.Drawing.Point(493, 3);
            this.admin_dataGridView.Name = "admin_dataGridView";
            this.admin_dataGridView.RowHeadersWidth = 51;
            this.admin_dataGridView.RowTemplate.Height = 24;
            this.admin_dataGridView.Size = new System.Drawing.Size(641, 508);
            this.admin_dataGridView.TabIndex = 20;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciSeviyesiDataGridViewTextBoxColumn
            // 
            this.kullaniciSeviyesiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciSeviyesi";
            this.kullaniciSeviyesiDataGridViewTextBoxColumn.HeaderText = "KullaniciSeviyesi";
            this.kullaniciSeviyesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciSeviyesiDataGridViewTextBoxColumn.Name = "kullaniciSeviyesiDataGridViewTextBoxColumn";
            this.kullaniciSeviyesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.vtys_projeDataSet;
            // 
            // vtys_projeDataSet
            // 
            this.vtys_projeDataSet.DataSetName = "vtys_projeDataSet";
            this.vtys_projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // userLevelBilgi_label
            // 
            this.userLevelBilgi_label.AutoSize = true;
            this.userLevelBilgi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLevelBilgi_label.Location = new System.Drawing.Point(3, 383);
            this.userLevelBilgi_label.Name = "userLevelBilgi_label";
            this.userLevelBilgi_label.Size = new System.Drawing.Size(413, 80);
            this.userLevelBilgi_label.TabIndex = 21;
            this.userLevelBilgi_label.Text = "User1: Sadece Okuma Yapabilir\r\nUser2: Okuma ve Yazma Yapabilir\r\nUser3: Okuma, Yaz" +
    "ma ve Güncelleme Yapabilir\r\nUser4: Okuma, Yazma, Güncelleme ve Silme Yapabilir";
            // 
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userLevelBilgi_label);
            this.Controls.Add(this.admin_dataGridView);
            this.Controls.Add(this.listele_Button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.kullanıcıOlustur_button);
            this.Controls.Add(this.kullanıcıSeviye_comboBox);
            this.Controls.Add(this.kullanıcıID_textBox);
            this.Controls.Add(this.kullanıcıAdı_textBox);
            this.Controls.Add(this.kullanıcıSeviye_label);
            this.Controls.Add(this.kullanıcıID_label);
            this.Controls.Add(this.kullanıcıAdı_label);
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(1137, 514);
            ((System.ComponentModel.ISupportInitialize)(this.admin_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanıcıAdı_textBox;
        private System.Windows.Forms.Label kullanıcıAdı_label;
        private System.Windows.Forms.Label kullanıcıSeviye_label;
        private System.Windows.Forms.ComboBox kullanıcıSeviye_comboBox;
        private System.Windows.Forms.Label kullanıcıID_label;
        private System.Windows.Forms.TextBox kullanıcıID_textBox;
        private System.Windows.Forms.Button kullanıcıOlustur_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button listele_Button;
        private System.Windows.Forms.DataGridView admin_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSeviyesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private vtys_projeDataSet vtys_projeDataSet;
        private vtys_projeDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.Label userLevelBilgi_label;
    }
}
