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
    public partial class UC_UyeTakvim : UserControl
    {
        public UC_UyeTakvim(string userLevel)
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

        private void gir_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if (uyeID_textBox.Text.Length > 0 && girisTarihi_textBox.Text.Length > 0 && cikisTarihi_textBox.Text.Length > 0)
                {
                    string insertQuery = "INSERT INTO UyeTakvim VALUES(@UyeID, @GirisTarihi, @CikisTarihi, NULL)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Conn);  // tablo adını değiştir
                    cmd.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    cmd.Parameters["@UyeID"].Value = uyeID_textBox.Text;

                    cmd.Parameters.Add("@GirisTarihi", SqlDbType.SmallDateTime);
                    cmd.Parameters["@GirisTarihi"].Value = girisTarihi_textBox.Text;

                    cmd.Parameters.Add("@CikisTarihi", SqlDbType.SmallDateTime);
                    cmd.Parameters["@CikisTarihi"].Value = cikisTarihi_textBox.Text;

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

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string updateQuery = "UPDATE UyeTakvim SET ";     // tablo adını değiştir
                SqlCommand cmd = new SqlCommand(updateQuery, Conn);
                int colummnCount = 0;
                int commaCount = 0;

                if (uyeID_textBox.Text.Length > 0)
                {
                    if (girisTarihi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        cmd.CommandText += "GirisTarihi = @GirisTarihi";
                        cmd.Parameters.Add("@GirisTarihi", SqlDbType.SmallDateTime);
                        cmd.Parameters["@GirisTarihi"].Value = girisTarihi_textBox.Text;
                    }

                    if (cikisTarihi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "CikisTarihi = @CikisTarihi";
                        cmd.Parameters.Add("@CikisTarihi", SqlDbType.SmallDateTime);
                        cmd.Parameters["@CikisTarihi"].Value = cikisTarihi_textBox.Text;
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

        private void sil_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if (uyeID_textBox.Text.Length > 0)
                {
                    girisTarihi_textBox.Clear();
                    cikisTarihi_textBox.Clear();
                    string deleteQuery = "DELETE FROM UyeTakvim WHERE UyeID = @UyeID"; ;
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

        private void ara_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string searchQuery = "SELECT * FROM UyeTakvim WHERE ";  // tablo adını değiştir
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

                if (girisTarihi_textBox.TextLength > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "GirisTarihi = @GirisTarihi ";
                    sda.SelectCommand.Parameters.Add("@GirisTarihi", SqlDbType.SmallDateTime);
                    sda.SelectCommand.Parameters["@GirisTarihi"].Value = girisTarihi_textBox.Text;
                }

                if (cikisTarihi_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "CikisTarihi = @CikisTarihi ";
                    sda.SelectCommand.Parameters.Add("@CikisTarihi", SqlDbType.SmallDateTime);
                    sda.SelectCommand.Parameters["@CikisTarihi"].Value = cikisTarihi_textBox.Text;
                }

                Console.WriteLine("Command text: " + sda.SelectCommand.CommandText);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uyeTakvim_dataGridView.DataSource = dataTable;
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

        private void listele_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string query = "SELECT * FROM UyeTakvim"; // tablo adını değiştir
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uyeTakvim_dataGridView.DataSource = dataTable;
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
