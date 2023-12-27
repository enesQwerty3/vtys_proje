
namespace Vtys_Proje
{
    partial class UC_UyeTakvim
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
            this.uyeTakvim_dataGridView = new System.Windows.Forms.DataGridView();
            this.vtys_projeDataSet = new Vtys_Proje.vtys_projeDataSet();
            this.uyeTakvimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeTakvimTableAdapter = new Vtys_Proje.vtys_projeDataSetTableAdapters.UyeTakvimTableAdapter();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamHarcananSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeID_textBox = new System.Windows.Forms.TextBox();
            this.uyeID_label = new System.Windows.Forms.Label();
            this.girisTarihi_label = new System.Windows.Forms.Label();
            this.cikisTarihi_label = new System.Windows.Forms.Label();
            this.girisTarihi_textBox = new System.Windows.Forms.TextBox();
            this.cikisTarihi_textBox = new System.Windows.Forms.TextBox();
            this.listele_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.gir_button = new System.Windows.Forms.Button();
            this.ara_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyeTakvim_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeTakvimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeTakvim_dataGridView
            // 
            this.uyeTakvim_dataGridView.AutoGenerateColumns = false;
            this.uyeTakvim_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeTakvim_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeIDDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn,
            this.toplamHarcananSureDataGridViewTextBoxColumn});
            this.uyeTakvim_dataGridView.DataSource = this.uyeTakvimBindingSource;
            this.uyeTakvim_dataGridView.Location = new System.Drawing.Point(432, 0);
            this.uyeTakvim_dataGridView.Name = "uyeTakvim_dataGridView";
            this.uyeTakvim_dataGridView.RowHeadersWidth = 51;
            this.uyeTakvim_dataGridView.RowTemplate.Height = 24;
            this.uyeTakvim_dataGridView.Size = new System.Drawing.Size(702, 511);
            this.uyeTakvim_dataGridView.TabIndex = 0;
            // 
            // vtys_projeDataSet
            // 
            this.vtys_projeDataSet.DataSetName = "vtys_projeDataSet";
            this.vtys_projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeTakvimBindingSource
            // 
            this.uyeTakvimBindingSource.DataMember = "UyeTakvim";
            this.uyeTakvimBindingSource.DataSource = this.vtys_projeDataSet;
            // 
            // uyeTakvimTableAdapter
            // 
            this.uyeTakvimTableAdapter.ClearBeforeFill = true;
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            this.uyeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            this.girisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            this.cikisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamHarcananSureDataGridViewTextBoxColumn
            // 
            this.toplamHarcananSureDataGridViewTextBoxColumn.DataPropertyName = "ToplamHarcananSure";
            this.toplamHarcananSureDataGridViewTextBoxColumn.HeaderText = "ToplamHarcananSure";
            this.toplamHarcananSureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamHarcananSureDataGridViewTextBoxColumn.Name = "toplamHarcananSureDataGridViewTextBoxColumn";
            this.toplamHarcananSureDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeID_textBox
            // 
            this.uyeID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeID_textBox.Location = new System.Drawing.Point(183, 54);
            this.uyeID_textBox.Name = "uyeID_textBox";
            this.uyeID_textBox.Size = new System.Drawing.Size(166, 26);
            this.uyeID_textBox.TabIndex = 4;
            // 
            // uyeID_label
            // 
            this.uyeID_label.AutoSize = true;
            this.uyeID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeID_label.Location = new System.Drawing.Point(18, 51);
            this.uyeID_label.Name = "uyeID_label";
            this.uyeID_label.Size = new System.Drawing.Size(96, 29);
            this.uyeID_label.TabIndex = 3;
            this.uyeID_label.Text = "Uye ID:";
            // 
            // girisTarihi_label
            // 
            this.girisTarihi_label.AutoSize = true;
            this.girisTarihi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihi_label.Location = new System.Drawing.Point(18, 129);
            this.girisTarihi_label.Name = "girisTarihi_label";
            this.girisTarihi_label.Size = new System.Drawing.Size(142, 29);
            this.girisTarihi_label.TabIndex = 3;
            this.girisTarihi_label.Text = "Giriş Tarihi:";
            // 
            // cikisTarihi_label
            // 
            this.cikisTarihi_label.AutoSize = true;
            this.cikisTarihi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisTarihi_label.Location = new System.Drawing.Point(18, 220);
            this.cikisTarihi_label.Name = "cikisTarihi_label";
            this.cikisTarihi_label.Size = new System.Drawing.Size(146, 29);
            this.cikisTarihi_label.TabIndex = 3;
            this.cikisTarihi_label.Text = "Çıkış Tarihi:";
            // 
            // girisTarihi_textBox
            // 
            this.girisTarihi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisTarihi_textBox.Location = new System.Drawing.Point(183, 134);
            this.girisTarihi_textBox.Name = "girisTarihi_textBox";
            this.girisTarihi_textBox.Size = new System.Drawing.Size(166, 26);
            this.girisTarihi_textBox.TabIndex = 4;
            // 
            // cikisTarihi_textBox
            // 
            this.cikisTarihi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisTarihi_textBox.Location = new System.Drawing.Point(183, 225);
            this.cikisTarihi_textBox.Name = "cikisTarihi_textBox";
            this.cikisTarihi_textBox.Size = new System.Drawing.Size(166, 26);
            this.cikisTarihi_textBox.TabIndex = 4;
            // 
            // listele_button
            // 
            this.listele_button.Location = new System.Drawing.Point(151, 380);
            this.listele_button.Name = "listele_button";
            this.listele_button.Size = new System.Drawing.Size(120, 23);
            this.listele_button.TabIndex = 15;
            this.listele_button.Text = "HepsiniListele";
            this.listele_button.UseVisualStyleBackColor = true;
            this.listele_button.Click += new System.EventHandler(this.listele_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Location = new System.Drawing.Point(219, 331);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(75, 23);
            this.sil_button.TabIndex = 11;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Location = new System.Drawing.Point(116, 331);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(85, 23);
            this.guncelle_button.TabIndex = 12;
            this.guncelle_button.Text = "Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // gir_button
            // 
            this.gir_button.Location = new System.Drawing.Point(23, 331);
            this.gir_button.Name = "gir_button";
            this.gir_button.Size = new System.Drawing.Size(75, 23);
            this.gir_button.TabIndex = 13;
            this.gir_button.Text = "Gir";
            this.gir_button.UseVisualStyleBackColor = true;
            this.gir_button.Click += new System.EventHandler(this.gir_button_Click);
            // 
            // ara_button
            // 
            this.ara_button.Location = new System.Drawing.Point(309, 331);
            this.ara_button.Name = "ara_button";
            this.ara_button.Size = new System.Drawing.Size(75, 23);
            this.ara_button.TabIndex = 14;
            this.ara_button.Text = "Ara";
            this.ara_button.UseVisualStyleBackColor = true;
            this.ara_button.Click += new System.EventHandler(this.ara_button_Click);
            // 
            // UC_UyeTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listele_button);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.gir_button);
            this.Controls.Add(this.ara_button);
            this.Controls.Add(this.cikisTarihi_textBox);
            this.Controls.Add(this.girisTarihi_textBox);
            this.Controls.Add(this.uyeID_textBox);
            this.Controls.Add(this.cikisTarihi_label);
            this.Controls.Add(this.girisTarihi_label);
            this.Controls.Add(this.uyeID_label);
            this.Controls.Add(this.uyeTakvim_dataGridView);
            this.Name = "UC_UyeTakvim";
            this.Size = new System.Drawing.Size(1137, 514);
            ((System.ComponentModel.ISupportInitialize)(this.uyeTakvim_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeTakvimBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uyeTakvim_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamHarcananSureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uyeTakvimBindingSource;
        private vtys_projeDataSet vtys_projeDataSet;
        private vtys_projeDataSetTableAdapters.UyeTakvimTableAdapter uyeTakvimTableAdapter;
        private System.Windows.Forms.TextBox uyeID_textBox;
        private System.Windows.Forms.Label uyeID_label;
        private System.Windows.Forms.Label girisTarihi_label;
        private System.Windows.Forms.Label cikisTarihi_label;
        private System.Windows.Forms.TextBox girisTarihi_textBox;
        private System.Windows.Forms.TextBox cikisTarihi_textBox;
        private System.Windows.Forms.Button listele_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button gir_button;
        private System.Windows.Forms.Button ara_button;
    }
}
