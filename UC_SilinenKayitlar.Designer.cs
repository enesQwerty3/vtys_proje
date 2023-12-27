
namespace Vtys_Proje
{
    partial class UC_SilinenKayitlar
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
            this.silinenUyeler_dataGridView = new System.Windows.Forms.DataGridView();
            this.vtys_projeDataSet = new Vtys_Proje.vtys_projeDataSet();
            this.silinenUyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silinenUyelerTableAdapter = new Vtys_Proje.vtys_projeDataSetTableAdapters.SilinenUyelerTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.silinenUyeler_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenUyelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // silinenUyeler_dataGridView
            // 
            this.silinenUyeler_dataGridView.AutoGenerateColumns = false;
            this.silinenUyeler_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.silinenUyeler_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn});
            this.silinenUyeler_dataGridView.DataSource = this.silinenUyelerBindingSource;
            this.silinenUyeler_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.silinenUyeler_dataGridView.Name = "silinenUyeler_dataGridView";
            this.silinenUyeler_dataGridView.RowHeadersWidth = 51;
            this.silinenUyeler_dataGridView.RowTemplate.Height = 24;
            this.silinenUyeler_dataGridView.Size = new System.Drawing.Size(1137, 514);
            this.silinenUyeler_dataGridView.TabIndex = 0;
            // 
            // vtys_projeDataSet
            // 
            this.vtys_projeDataSet.DataSetName = "vtys_projeDataSet";
            this.vtys_projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // silinenUyelerBindingSource
            // 
            this.silinenUyelerBindingSource.DataMember = "SilinenUyeler";
            this.silinenUyelerBindingSource.DataSource = this.vtys_projeDataSet;
            // 
            // silinenUyelerTableAdapter
            // 
            this.silinenUyelerTableAdapter.ClearBeforeFill = true;
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
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // UC_SilinenKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.silinenUyeler_dataGridView);
            this.Name = "UC_SilinenKayitlar";
            this.Size = new System.Drawing.Size(1137, 514);
            ((System.ComponentModel.ISupportInitialize)(this.silinenUyeler_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtys_projeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silinenUyelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView silinenUyeler_dataGridView;
        private System.Windows.Forms.BindingSource silinenUyelerBindingSource;
        private vtys_projeDataSet vtys_projeDataSet;
        private vtys_projeDataSetTableAdapters.SilinenUyelerTableAdapter silinenUyelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
    }
}
