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
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
            /*if(userLevel != "Admin")
                listele_Button.Enabled = false;*/
        }

        
        private void listele_Button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();
            

            try
            {
                string selectQuery = "Select * From Kullanici";
                SqlDataAdapter sda = new SqlDataAdapter(selectQuery, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                admin_dataGridView.DataSource = dataTable;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Conn.Close();
            }

        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string updateQuery = "UPDATE Kullanici SET ";     // tablo adını değiştir
                SqlCommand cmd = new SqlCommand(updateQuery, Conn);
                int colummnCount = 0;
                int commaCount = 0;

                if (kullanıcıID_textBox.Text.Length > 0)
                {
                    if (kullanıcıAdı_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        cmd.CommandText += "KullaniciAdi = @KullaniciAdi";
                        cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 10);
                        cmd.Parameters["@KullaniciAdi"].Value = kullanıcıAdı_textBox.Text;
                    }

                    if (kullanıcıSeviye_comboBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "KullaniciSeviyesi = @KullaniciSeviyesi";
                        cmd.Parameters.Add("@KullaniciSeviyesi", SqlDbType.VarChar, 10);
                        cmd.Parameters["@KullaniciSeviyesi"].Value = kullanıcıSeviye_comboBox.Text;
                    }

                    cmd.CommandText += " WHERE KullaniciID = @KullaniciID";
                    cmd.Parameters.Add("@KullaniciID", SqlDbType.TinyInt);
                    cmd.Parameters["@KullaniciID"].Value = kullanıcıID_textBox.Text;

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir KullaniciID değeri giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Conn.Close();
            }
        }

        private void kullanıcıOlustur_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if (kullanıcıAdı_textBox.Text.Length > 0 && kullanıcıSeviye_comboBox.Text.Length > 0)
                {
                    kullanıcıID_textBox.Clear();
                    string insertQuery = "INSERT INTO Kullanici VALUES(@KullaniciAdi, NULL, @KullaniciSeviyesi)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Conn);  // tablo adını değiştir
                    
                    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar, 10);
                    cmd.Parameters["@KullaniciAdi"].Value = kullanıcıAdı_textBox.Text;

                    cmd.Parameters.Add("@KullaniciSeviyesi", SqlDbType.VarChar, 10);
                    cmd.Parameters["@KullaniciSeviyesi"].Value = kullanıcıSeviye_comboBox.Text;

                    cmd.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Lütfen tam dolu kayıt girişi yapınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Conn.Close();
            }
        }
    }
}
