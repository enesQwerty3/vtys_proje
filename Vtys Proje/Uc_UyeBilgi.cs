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
    public partial class Uc_UyeBilgi : UserControl
    {
        public Uc_UyeBilgi(string userLevel)
        {
            InitializeComponent();
            if (userLevel == "User1")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = false;
                guncelle_button.Enabled = false;
                sil_button.Enabled = false;
            }

            if (userLevel == "User2")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = true;
                guncelle_button.Enabled = false;
                sil_button.Enabled = false;
            }

            if (userLevel == "User3")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = true;
                guncelle_button.Enabled = true;
                sil_button.Enabled = false;
            }

            if (userLevel == "User4")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = true;
                guncelle_button.Enabled = true;
                sil_button.Enabled = true;
            }

            if (userLevel == "Admin")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = true;
                guncelle_button.Enabled = true;
                sil_button.Enabled = true;
            }
        }

        private void ara_button_Click(object sender, EventArgs e)      // SEARCH
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string searchQuery = "SELECT * FROM UyelikBilgi WHERE ";  // tablo adını değiştir
                SqlDataAdapter sda = new SqlDataAdapter(searchQuery, Conn);

                int columnCount = 0;
                int andCount = 0;

                if (uyeID_textBox.TextLength > 0)
                {
                    columnCount++;
                    sda.SelectCommand.CommandText += "UyeID = @UyeID ";
                    sda.SelectCommand.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    sda.SelectCommand.Parameters["@UyeID"].Value = uyeID_textBox.Text;
                }

                if (uyelikBaslangıcTarihi_textBox.TextLength > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "UyelikBaslangicTarihi = @UyelikBaslangicTarihi ";
                    sda.SelectCommand.Parameters.Add("@UyelikBaslangicTarihi", SqlDbType.Date);
                    sda.SelectCommand.Parameters["@UyelikBaslangicTarihi"].Value = uyelikBaslangıcTarihi_textBox.Text;
                }

                if (uyelikBitisTarihi_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "UyelikBitisTarihi = @UyelikBitisTarihi ";
                    sda.SelectCommand.Parameters.Add("@UyelikBitisTarihi", SqlDbType.Date);
                    sda.SelectCommand.Parameters["@UyelikBitisTarihi"].Value = uyelikBitisTarihi_textBox.Text;
                }

                if (uyelikSeviyesi_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "UyelikSeviyesi = @UyelikSeviyesi ";
                    sda.SelectCommand.Parameters.Add("@UyelikSeviyesi", SqlDbType.VarChar, 8);
                    sda.SelectCommand.Parameters["@UyelikSeviyesi"].Value = uyelikSeviyesi_textBox.Text;
                }

                if (brans_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Brans = @Brans ";
                    sda.SelectCommand.Parameters.Add("@Brans", SqlDbType.VarChar, 10);
                    sda.SelectCommand.Parameters["@Brans"].Value = brans_textBox.Text;
                }

                Console.WriteLine("Command text: " + sda.SelectCommand.CommandText);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uyeBilgi_dataGridView.DataSource = dataTable;
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

        private void listele_button_Click(object sender, EventArgs e)  // SELECT
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string query = "SELECT * FROM UyelikBilgi"; // tablo adını değiştir
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uyeBilgi_dataGridView.DataSource = dataTable;
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

        private void gir_button_Click(object sender, EventArgs e)      // INSERT
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if (uyeID_textBox.Text.Length > 0 && uyelikBaslangıcTarihi_textBox.Text.Length > 0 && uyelikBitisTarihi_textBox.Text.Length > 0 && uyelikSeviyesi_textBox.Text.Length > 0 && brans_textBox.Text.Length > 0)
                {
                    string insertQuery = "INSERT INTO UyelikBilgi VALUES(@UyeID, @UyelikBaslangicTarihi, @UyelikBitisTarihi, @UyelikSeviyesi, @Brans)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Conn);  // tablo adını değiştir
                    cmd.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    cmd.Parameters["@UyeID"].Value = uyeID_textBox.Text;

                    cmd.Parameters.Add("@UyelikBaslangicTarihi", SqlDbType.Date);
                    cmd.Parameters["@UyelikBaslangicTarihi"].Value = uyelikBaslangıcTarihi_textBox.Text;

                    cmd.Parameters.Add("@UyelikBitisTarihi", SqlDbType.Date);
                    cmd.Parameters["@UyelikBitisTarihi"].Value = uyelikBitisTarihi_textBox.Text;

                    cmd.Parameters.Add("@UyelikSeviyesi", SqlDbType.VarChar, 8);
                    cmd.Parameters["@UyelikSeviyesi"].Value = uyelikSeviyesi_textBox.Text;

                    cmd.Parameters.Add("@Brans", SqlDbType.VarChar, 10);
                    cmd.Parameters["@Brans"].Value = brans_textBox.Text;

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

        private void guncelle_button_Click(object sender, EventArgs e)     // UPDATE
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string updateQuery = "UPDATE UyelikBilgi SET ";     // tablo adını değiştir
                SqlCommand cmd = new SqlCommand(updateQuery, Conn);
                int colummnCount = 0;
                int commaCount = 0;

                if (uyeID_textBox.Text.Length > 0)
                {
                    if (uyelikBaslangıcTarihi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        cmd.CommandText += "UyelikBaslangicTarihi = @UyelikBaslangicTarihi";
                        cmd.Parameters.Add("@UyelikBaslangicTarihi", SqlDbType.Date);
                        cmd.Parameters["@UyelikBaslangicTarihi"].Value = uyelikBaslangıcTarihi_textBox.Text;
                    }

                    if (uyelikBitisTarihi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "UyelikBitisTarihi = @UyelikBitisTarihi";
                        cmd.Parameters.Add("@UyelikBitisTarihi", SqlDbType.Date);
                        cmd.Parameters["@UyelikBitisTarihi"].Value = uyelikBitisTarihi_textBox.Text;
                    }

                    if (uyelikSeviyesi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "UyelikSeviyesi = @UyelikSeviyesi";
                        cmd.Parameters.Add("@UyelikSeviyesi", SqlDbType.VarChar, 8);
                        cmd.Parameters["@UyelikSeviyesi"].Value = uyelikSeviyesi_textBox.Text;
                    }

                    if (brans_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "Brans = @Brans";
                        cmd.Parameters.Add("@Brans", SqlDbType.VarChar, 10);
                        cmd.Parameters["@Brans"].Value = brans_textBox.Text;
                    }

                    cmd.CommandText += " WHERE UyeID = @UyeID";
                    cmd.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    cmd.Parameters["@UyeID"].Value = uyeID_textBox.Text;

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir UyeID değeri giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void sil_button_Click(object sender, EventArgs e)  // DELETE
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if (uyeID_textBox.Text.Length > 0)
                {
                    uyelikBaslangıcTarihi_textBox.Clear();
                    uyelikBitisTarihi_textBox.Clear();
                    uyelikSeviyesi_textBox.Clear();
                    brans_textBox.Clear();
                    string deleteQuery = "DELETE FROM UyelikBilgi WHERE UyeID = @UyeID"; ;
                    SqlCommand cmd = new SqlCommand(deleteQuery, Conn);
                    cmd.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    cmd.Parameters["@UyeID"].Value = uyeID_textBox.Text;
                    cmd.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Lüften kayıt silmek için bir UyeID değeri giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

