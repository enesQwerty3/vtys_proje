using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vtys_Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void giris_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();
            String username, password;
            username = kullanıcıAdi_textBox.Text;
            password = sifre_textBox.Text;

            try
            {
                String sqlQuery = $" SELECT DISTINCT* FROM Kullanici WHERE KullaniciAdi = '{username}' AND Sifre = '{password}'";
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, Conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    var userLevel = dtable.Rows[0][3];   //get user level from KullaniciSeviye column from data table
                    Menu MenuForm = new Menu();
                    MenuForm.SetUserLevel(userLevel.ToString());
                    MenuForm.Show();
                    this.Hide();
                    //this.Dispose();
                }

                else
                {
                    MessageBox.Show("Gecersiz giris bilgisi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kullanıcıAdi_textBox.Clear();
                    sifre_textBox.Clear();
                    kullanıcıAdi_textBox.Focus();
                }

            }

            catch
            {
                MessageBox.Show("Hata!");
            }

            finally
            {
                Conn.Close();
            }
        }
    }
}
