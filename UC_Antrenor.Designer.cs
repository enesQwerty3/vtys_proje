
namespace Vtys_Proje
{
    partial class UC_Antrenor
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
            this.antrenor_dataGridView = new System.Windows.Forms.DataGridView();
            this.vtys_projeDataSet = new Vtys_Proje.vtys_projeDataSet();
            this.antrenorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antrenorTableAdapter = new Vtys_Proje.vtys_projeDataSetTableAdapters.AntrenorTableAdapter();
            this.antrenorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antrenorID_textBox = new System.Windows.Forms.TextBox();
            this.antrenorID_label = new System.Windows.Forms.Label();
            this.ad_label = new System.Windows.Forms.Label();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.soyad_label = new System.Windows.Forms.Label();
            this.soyad_textBox = new System.Windows.Forms.TextBox();
            this.brans_label = new System.Windows.Forms.Label();
            this.brans_textBox = new System.Windows.Forms.TextBox();
            this.listele_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.gir_button = new System.Windows.Forms.Button();
            this.ara_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.antrenor_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // antrenor_dataGridView
            // 
            this.antrenor_dataGridView.AutoGenerateColumns = false;
            this.antrenor_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antrenor_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.antrenorIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn});
            this.antrenor_dataGridView.DataSource = this.antrenorBindingSource;
            this.antrenor_dataGridView.Location = new System.Drawing.Point(432, 0);
            this.antrenor_dataGridView.Name = "antrenor_dataGridView";
            this.antrenor_dataGridView.RowHeadersWidth = 51;
            this.antrenor_dataGridView.RowTemplate.Height = 24;
            this.antrenor_dataGridView.Size = new System.Drawing.Size(702, 511);
            this.antrenor_dataGridView.TabIndex = 0;
            // 
            // vtys_projeDataSet
            // 
            this.vtys_projeDataSet.DataSetName = "vtys_projeDataSet";
            this.vtys_projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // antrenorBindingSource
            // 
            this.antrenorBindingSource.DataMember = "Antrenor";
            this.antrenorBindingSource.DataSource = this.vtys_projeDataSet;
            // 
            // antrenorTableAdapter
            // 
            this.antrenorTableAdapter.ClearBeforeFill = true;
            // 
            // antrenorIDDataGridViewTextBoxColumn
            // 
            this.antrenorIDDataGridViewTextBoxColumn.DataPropertyName = "AntrenorID";
            this.antrenorIDDataGridViewTextBoxColumn.HeaderText = "AntrenorID";
            this.antrenorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.antrenorIDDataGridViewTextBoxColumn.Name = "antrenorIDDataGridViewTextBoxColumn";
            this.antrenorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.antrenorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bransDataGridViewTextBoxColumn
            // 
            this.bransDataGridViewTextBoxColumn.DataPropertyName = "Brans";
            this.bransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.bransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransDataGridViewTextBoxColumn.Name = "bransDataGridViewTextBoxColumn";
            this.bransDataGridViewTextBoxColumn.Width = 125;
            // 
            // antrenorID_textBox
            // 
            this.antrenorID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antrenorID_textBox.Location = new System.Drawing.Point(193, 58);
            this.antrenorID_textBox.Name = "antrenorID_textBox";
            this.antrenorID_textBox.Size = new System.Drawing.Size(166, 26);
            this.antrenorID_textBox.TabIndex = 6;
            // 
            // antrenorID_label
            // 
            this.antrenorID_label.AutoSize = true;
            this.antrenorID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antrenorID_label.Location = new System.Drawing.Point(28, 55);
            this.antrenorID_label.Name = "antrenorID_label";
            this.antrenorID_label.Size = new System.Drawing.Size(147, 29);
            this.antrenorID_label.TabIndex = 5;
            this.antrenorID_label.Text = "Antrenor ID:";
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_label.Location = new System.Drawing.Point(28, 136);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(51, 29);
            this.ad_label.TabIndex = 5;
            this.ad_label.Text = "Ad:";
            // 
            // ad_textBox
            // 
            this.ad_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_textBox.Location = new System.Drawing.Point(193, 139);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(166, 26);
            this.ad_textBox.TabIndex = 6;
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad_label.Location = new System.Drawing.Point(28, 218);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(92, 29);
            this.soyad_label.TabIndex = 5;
            this.soyad_label.Text = "Soyad:";
            // 
            // soyad_textBox
            // 
            this.soyad_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad_textBox.Location = new System.Drawing.Point(193, 221);
            this.soyad_textBox.Name = "soyad_textBox";
            this.soyad_textBox.Size = new System.Drawing.Size(166, 26);
            this.soyad_textBox.TabIndex = 6;
            // 
            // brans_label
            // 
            this.brans_label.AutoSize = true;
            this.brans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brans_label.Location = new System.Drawing.Point(28, 299);
            this.brans_label.Name = "brans_label";
            this.brans_label.Size = new System.Drawing.Size(86, 29);
            this.brans_label.TabIndex = 5;
            this.brans_label.Text = "Brans:";
            // 
            // brans_textBox
            // 
            this.brans_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brans_textBox.Location = new System.Drawing.Point(193, 302);
            this.brans_textBox.Name = "brans_textBox";
            this.brans_textBox.Size = new System.Drawing.Size(166, 26);
            this.brans_textBox.TabIndex = 6;
            // 
            // listele_button
            // 
            this.listele_button.Location = new System.Drawing.Point(164, 442);
            this.listele_button.Name = "listele_button";
            this.listele_button.Size = new System.Drawing.Size(120, 23);
            this.listele_button.TabIndex = 20;
            this.listele_button.Text = "HepsiniListele";
            this.listele_button.UseVisualStyleBackColor = true;
            this.listele_button.Click += new System.EventHandler(this.listele_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Location = new System.Drawing.Point(232, 393);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(75, 23);
            this.sil_button.TabIndex = 16;
            this.sil_button.Text = "Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Location = new System.Drawing.Point(129, 393);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(85, 23);
            this.guncelle_button.TabIndex = 17;
            this.guncelle_button.Text = "Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // gir_button
            // 
            this.gir_button.Location = new System.Drawing.Point(36, 393);
            this.gir_button.Name = "gir_button";
            this.gir_button.Size = new System.Drawing.Size(75, 23);
            this.gir_button.TabIndex = 18;
            this.gir_button.Text = "Gir";
            this.gir_button.UseVisualStyleBackColor = true;
            this.gir_button.Click += new System.EventHandler(this.gir_button_Click);
            // 
            // ara_button
            // 
            this.ara_button.Location = new System.Drawing.Point(322, 393);
            this.ara_button.Name = "ara_button";
            this.ara_button.Size = new System.Drawing.Size(75, 23);
            this.ara_button.TabIndex = 19;
            this.ara_button.Text = "Ara";
            this.ara_button.UseVisualStyleBackColor = true;
            this.ara_button.Click += new System.EventHandler(this.ara_button_Click);
            // 
            // UC_Antrenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listele_button);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.gir_button);
            this.Controls.Add(this.ara_button);
            this.Controls.Add(this.brans_textBox);
            this.Controls.Add(this.soyad_textBox);
            this.Controls.Add(this.ad_textBox);
            this.Controls.Add(this.antrenorID_textBox);
            this.Controls.Add(this.brans_label);
            this.Controls.Add(this.soyad_label);
            this.Controls.Add(this.ad_label);
            this.Controls.Add(this.antrenorID_label);
            this.Controls.Add(this.antrenor_dataGridView);
            this.Name = "UC_Antrenor";
            this.Size = new System.Drawing.Size(1137, 514);
            ((System.ComponentModel.ISupportInitialize)(this.antrenor_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView antrenor_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn antrenorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource antrenorBindingSource;
        private vtys_projeDataSet vtys_projeDataSet;
        private vtys_projeDataSetTableAdapters.AntrenorTableAdapter antrenorTableAdapter;
        private System.Windows.Forms.TextBox antrenorID_textBox;
        private System.Windows.Forms.Label antrenorID_label;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.TextBox soyad_textBox;
        private System.Windows.Forms.Label brans_label;
        private System.Windows.Forms.TextBox brans_textBox;
        private System.Windows.Forms.Button listele_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button gir_button;
        private System.Windows.Forms.Button ara_button;
    }
}
