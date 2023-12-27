using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vtys_Proje
{
    public partial class Menu : Form
    {
        private string userLevel;
        public Menu()
        {
            InitializeComponent();
            //this.Show();
        }

        public void SetUserLevel(string level)
        {
            userLevel = level;
            userLevel_label.Text += userLevel;
        }
        private void AddUserContol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void uyeIslemleriButton_Click(object sender, EventArgs e)
        {
            UC_Uye uc = new UC_Uye(this.userLevel);
            AddUserContol(uc);
        }

        private void uyeBilgiButton_Click(object sender, EventArgs e)
        {
            Uc_UyeBilgi uc = new Uc_UyeBilgi(this.userLevel);
            AddUserContol(uc);
        }

        private void silinenKayıtlarButton_Click(object sender, EventArgs e)
        {
            UC_SilinenKayitlar uc = new UC_SilinenKayitlar();
            AddUserContol(uc);
        }

        private void uyeTakvimButton_Click(object sender, EventArgs e)
        {
            UC_UyeTakvim uc = new UC_UyeTakvim(this.userLevel);
            AddUserContol(uc);
        }

        private void antreborButton_Click(object sender, EventArgs e)
        {
            UC_Antrenor uc = new UC_Antrenor(this.userLevel);
            AddUserContol(uc);
        }

        private void yedeklemeButton_Click(object sender, EventArgs e)
        {
            UC_Yedekleme uc = new UC_Yedekleme();
            AddUserContol(uc);
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            if(this.userLevel == "Admin")
            {
                UC_Admin uc = new UC_Admin();
                AddUserContol(uc);
            }

            else
            {
                MessageBox.Show("Yetersiz Kullanıcı Seviyesi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

}
