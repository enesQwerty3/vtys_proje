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
    public partial class UC_Antrenor : UserControl
    {
        public UC_Antrenor(string userLevel)
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
                if (ad_textBox.Text.Length > 0 && soyad_textBox.Text.Length > 0 && brans_textBox.Text.Length > 0)
                {
                    antrenorID_textBox.Clear();
                    string insertQuery = "INSERT INTO Antrenor VALUES(@Ad, @Soyad, @Brans)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Conn);  // tablo adını değiştir
                    cmd.Parameters.Add("@Ad", SqlDbType.VarChar, 10);
                    cmd.Parameters["@Ad"].Value = ad_textBox.Text;

                    cmd.Parameters.Add("@Soyad", SqlDbType.VarChar, 10);
                    cmd.Parameters["@Soyad"].Value = soyad_textBox.Text;

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

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string updateQuery = "UPDATE Antrenor SET ";     // tablo adını değiştir
                SqlCommand cmd = new SqlCommand(updateQuery, Conn);
                int colummnCount = 0;
                int commaCount = 0;

                if (antrenorID_textBox.Text.Length > 0)
                {
                    if (ad_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        cmd.CommandText += "Ad = @Ad";
                        cmd.Parameters.Add("@Ad", SqlDbType.VarChar, 10);
                        cmd.Parameters["@Ad"].Value = ad_textBox.Text;
                    }

                    if (soyad_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "Soyad = @Soyad";
                        cmd.Parameters.Add("@Soyad", SqlDbType.VarChar, 10);
                        cmd.Parameters["@Soyad"].Value = soyad_textBox.Text;
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

                    cmd.CommandText += " WHERE AntrenorID = @AntrenorID";
                    cmd.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                    cmd.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir AntrenorID değeri giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (antrenorID_textBox.Text.Length > 0)
                {
                    ad_textBox.Clear();
                    soyad_textBox.Clear();
                    brans_textBox.Clear();
                    string deleteQuery = "DELETE FROM Antrenor WHERE AntrenorID = @AntrenorID"; ;
                    SqlCommand cmd = new SqlCommand(deleteQuery, Conn);
                    cmd.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                    cmd.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;
                    cmd.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Lüften kayıt silmek için bir AntrenorID değeri giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string searchQuery = "SELECT * FROM Antrenor WHERE ";  // tablo adını değiştir
                SqlDataAdapter sda = new SqlDataAdapter(searchQuery, Conn);

                int columnCount = 0;
                int andCount = 0;

                if (antrenorID_textBox.TextLength > 0)
                {
                    columnCount++;
                    sda.SelectCommand.CommandText += "AntrenorID = @AntrenorID ";
                    sda.SelectCommand.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                    sda.SelectCommand.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;
                }

                if (ad_textBox.TextLength > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Ad = @Ad ";
                    sda.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar, 10);
                    sda.SelectCommand.Parameters["@Ad"].Value = ad_textBox.Text;
                }

                if (soyad_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Soyad = @Soyad ";
                    sda.SelectCommand.Parameters.Add("@Soyad", SqlDbType.VarChar, 10);
                    sda.SelectCommand.Parameters["@Soyad"].Value = soyad_textBox.Text;
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
                antrenor_dataGridView.DataSource = dataTable;
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
                string query = "SELECT * FROM Antrenor"; // tablo adını değiştir
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                antrenor_dataGridView.DataSource = dataTable;
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
