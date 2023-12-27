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
    public partial class UC_Uye : UserControl
    {
        public UC_Uye(string userLevel)
        {
            InitializeComponent();

            if(userLevel == "User1")
            {
                ara_button.Enabled = true;
                listele_button.Enabled = true;
                gir_button.Enabled = false;                
                guncelle_button.Enabled = false;
                sil_button.Enabled = false;
            }

            if(userLevel == "User2")
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
                //"SELECT * FROM Uye";
                string searchQuery = "SELECT * FROM Uye WHERE ";
                SqlDataAdapter sda = new SqlDataAdapter(searchQuery, Conn);
                //SqlCommand searchQuery = new SqlCommand(commandString, Connection);
                //searchQuery.CommandText = "SELECT * FROM Uye WHERE ";
                
                int columnCount = 0;
                int andCount = 0;
                //sda.SelectCommand.CommandText += "UyeID = 9";  deneme için -> çalışıyor

                if(uyeID_textBox.TextLength > 0)
                {
                    columnCount++;
                    sda.SelectCommand.CommandText += "UyeID = @UyeID ";
                    sda.SelectCommand.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    sda.SelectCommand.Parameters["@UyeID"].Value = uyeID_textBox.Text;
                    //searchQuery.CommandText += "UyeID = @UyeID ";
                    /*searchQuery.Parameters.Add("@ID", SqlDbType.SmallInt);
                    searchQuery.Parameters["@ID"].Value = uyeID_textBox.Text;*/
                    //searchQuery.Parameters.AddWithValue("@UyeID", uyeID_textBox.Text);
                    /*
                     command.Parameters.Add("@ID", SqlDbType.Int);
                     command.Parameters["@ID"].Value = customerID;
                     */

                }
                //da.SelectCommand.Parameters.Add("@search", SqlDbType.NVarChar, 2000).Value = "%" + txtSearch.Text + "%";
                //sda.SelectCommand.CommandText += newCommandText;
                if(ad_textBox.TextLength > 0)
                {
                    columnCount++;
                    if(columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Ad = @Ad ";
                    sda.SelectCommand.Parameters.Add("@Ad", SqlDbType.VarChar, 15);
                    sda.SelectCommand.Parameters["@Ad"].Value = ad_textBox.Text;
                }

                if(soyad_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if(columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Soyad = @Soyad ";
                    sda.SelectCommand.Parameters.Add("@Soyad", SqlDbType.VarChar, 15);
                    sda.SelectCommand.Parameters["@Soyad"].Value = soyad_textBox.Text;
                }

                if(tc_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "Tc = @Tc ";
                    sda.SelectCommand.Parameters.Add("@Tc", SqlDbType.Char, 11);
                    sda.SelectCommand.Parameters["@Tc"].Value = tc_textBox.Text;
                }

                if(dogumTarihi_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "DogumTarihi = @DogumTarihi ";
                    sda.SelectCommand.Parameters.Add("@DogumTarihi", SqlDbType.Date);
                    sda.SelectCommand.Parameters["@DogumTarihi"].Value = dogumTarihi_textBox.Text;
                }

                if(antrenorID_textBox.Text.Length > 0)
                {
                    columnCount++;
                    if (columnCount > 0 && columnCount - andCount != 1)
                    {
                        andCount++;
                        sda.SelectCommand.CommandText += "AND ";
                    }
                    sda.SelectCommand.CommandText += "AntrenorID = @AntrenorID ";
                    sda.SelectCommand.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                    sda.SelectCommand.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;
                }

                Console.WriteLine("Command text: " + sda.SelectCommand.CommandText);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uye_dataGridView.DataSource = dataTable;
                //searchQuery.Connection = Conn;
                //searchQuery.ExecuteNonQuery();
                

                //uye_dataGridView
            }

            catch(Exception ex)
            {
                //ex.ToString()      // ex.Message dan daha detaylı
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
                string query = "SELECT * FROM Uye";
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                uye_dataGridView.DataSource = dataTable;
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

        private void gir_button_Click(object sender, EventArgs e)      // INSERT
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                if(ad_textBox.Text.Length > 0 && soyad_textBox.Text.Length > 0 && tc_textBox.Text.Length > 0 && dogumTarihi_textBox.Text.Length > 0 && antrenorID_textBox.Text.Length > 0)
                {
                    uyeID_textBox.Clear();

                    string insertQuery = "INSERT INTO Uye VALUES(@Ad, @Soyad, @Tc, @DogumTarihi, @AntrenorID)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Conn);
                    cmd.Parameters.Add("@Ad", SqlDbType.VarChar, 15);
                    cmd.Parameters["@Ad"].Value = ad_textBox.Text;

                    cmd.Parameters.Add("@Soyad", SqlDbType.VarChar, 15);
                    cmd.Parameters["@Soyad"].Value = soyad_textBox.Text;

                    cmd.Parameters.Add("@Tc", SqlDbType.Char, 11);
                    cmd.Parameters["@Tc"].Value = tc_textBox.Text;

                    cmd.Parameters.Add("@Dogumtarihi", SqlDbType.Date);
                    cmd.Parameters["@Dogumtarihi"].Value = dogumTarihi_textBox.Text;

                    cmd.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                    cmd.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;

                    cmd.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Lütfen tam dolu kayıt girişi yapınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void guncelle_button_Click(object sender, EventArgs e)     // UPDATE
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string updateQuery= "UPDATE Uye SET ";
                /*
                uyeID_textBox.Text
                ad_textBox.Text
                soyad_textBox.Text
                tc_textBox.Text
                dogumTarihi_textBox.Text
                antrenorID_textBox.Text            
                 */
                SqlCommand cmd = new SqlCommand(updateQuery, Conn);
                int colummnCount = 0;
                int commaCount = 0;

                if (uyeID_textBox.Text.Length > 0)
                {
                    if (ad_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        cmd.CommandText += "Ad = @Ad";
                        cmd.Parameters.Add("@Ad", SqlDbType.VarChar, 15);
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
                        cmd.Parameters.Add("@Soyad", SqlDbType.VarChar, 15);
                        cmd.Parameters["@Soyad"].Value = soyad_textBox.Text;
                    }

                    if (tc_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "Tc = @Tc";
                        cmd.Parameters.Add("@Tc", SqlDbType.Char, 11);
                        cmd.Parameters["@Tc"].Value = tc_textBox.Text;
                    }

                    if (dogumTarihi_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "Dogumtarihi = @Dogumtarihi";
                        cmd.Parameters.Add("@Dogumtarihi", SqlDbType.Date);
                        cmd.Parameters["@Dogumtarihi"].Value = dogumTarihi_textBox.Text;
                    }

                    if (antrenorID_textBox.Text.Length > 0)
                    {
                        colummnCount++;
                        if (colummnCount > 0 && colummnCount - commaCount != 1)
                        {
                            commaCount++;
                            cmd.CommandText += ", ";
                        }
                        cmd.CommandText += "AntrenorID = @AntrenorID";
                        cmd.Parameters.Add("@AntrenorID", SqlDbType.SmallInt);
                        cmd.Parameters["@AntrenorID"].Value = antrenorID_textBox.Text;
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

            catch(Exception ex)
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
                if(uyeID_textBox.Text.Length > 0)
                {
                    ad_textBox.Clear();
                    soyad_textBox.Clear();
                    tc_textBox.Clear();
                    dogumTarihi_textBox.Clear();
                    antrenorID_textBox.Clear();
                    string deleteQuery = "DELETE FROM Uye WHERE UyeID = @UyeID"; ;
                    SqlCommand cmd = new SqlCommand(deleteQuery, Conn);
                    //cmd.CommandText = "DELETE FROM Uye WHERE UyeID = @UyeID";
                    cmd.Parameters.Add("@UyeID", SqlDbType.SmallInt);
                    cmd.Parameters["@UyeID"].Value = uyeID_textBox.Text;
                    cmd.ExecuteNonQuery();
                }

                else
                {
                    MessageBox.Show("Lüften kayıt silmek için bir UyeID değeri giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
