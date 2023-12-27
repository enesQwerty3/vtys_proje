
namespace Vtys_Proje
{
    partial class Login
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
            this.giris_label = new System.Windows.Forms.Label();
            this.kullanıcıAdı_label = new System.Windows.Forms.Label();
            this.sifre_label = new System.Windows.Forms.Label();
            this.kullanıcıAdi_textBox = new System.Windows.Forms.TextBox();
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            this.giris_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_label
            // 
            this.giris_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giris_label.AutoSize = true;
            this.giris_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_label.Location = new System.Drawing.Point(12, 73);
            this.giris_label.Name = "giris_label";
            this.giris_label.Size = new System.Drawing.Size(489, 39);
            this.giris_label.TabIndex = 0;
            this.giris_label.Text = "Spor Salonu Veritabanı Sistemi";
            // 
            // kullanıcıAdı_label
            // 
            this.kullanıcıAdı_label.AutoSize = true;
            this.kullanıcıAdı_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdı_label.Location = new System.Drawing.Point(67, 172);
            this.kullanıcıAdı_label.Name = "kullanıcıAdı_label";
            this.kullanıcıAdı_label.Size = new System.Drawing.Size(106, 20);
            this.kullanıcıAdı_label.TabIndex = 1;
            this.kullanıcıAdı_label.Text = "Kullanıcı Adı:";
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.Location = new System.Drawing.Point(67, 226);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(49, 20);
            this.sifre_label.TabIndex = 1;
            this.sifre_label.Text = "Şifre:";
            // 
            // kullanıcıAdi_textBox
            // 
            this.kullanıcıAdi_textBox.Location = new System.Drawing.Point(202, 172);
            this.kullanıcıAdi_textBox.Name = "kullanıcıAdi_textBox";
            this.kullanıcıAdi_textBox.Size = new System.Drawing.Size(155, 22);
            this.kullanıcıAdi_textBox.TabIndex = 2;
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(202, 224);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(155, 22);
            this.sifre_textBox.TabIndex = 2;
            this.sifre_textBox.UseSystemPasswordChar = true;
            // 
            // giris_button
            // 
            this.giris_button.Location = new System.Drawing.Point(238, 304);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(75, 23);
            this.giris_button.TabIndex = 3;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(532, 418);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.kullanıcıAdi_textBox);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kullanıcıAdı_label);
            this.Controls.Add(this.giris_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label giris_label;
        private System.Windows.Forms.Label kullanıcıAdı_label;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.TextBox kullanıcıAdi_textBox;
        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.Button giris_button;
    }
}

