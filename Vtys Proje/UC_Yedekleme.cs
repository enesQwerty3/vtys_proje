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
    public partial class UC_Yedekleme : UserControl
    {
        public UC_Yedekleme()
        {
            InitializeComponent();
        }

        private void konumSec_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            //dlg.ShowDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                yedeklemeKonum_textBox.Text = dlg.SelectedPath;
            }

        }

        private void yedekle_button_Click(object sender, EventArgs e)
        {
            if(yedeklemeKonum_textBox.Text.Length > 0 && yedekAd_textBox.Text.Length > 0)
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
                Conn.Open();

                try
                {
                    string backupQuery = "BACKUP DATABASE vtysProje " +
                        "TO DISK = '" + yedeklemeKonum_textBox.Text + "\\" + yedekAd_textBox.Text + ".bak'";
                    Console.WriteLine(backupQuery);
                    SqlCommand cmd = new SqlCommand(backupQuery, Conn);
                    cmd.ExecuteNonQuery();
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

            else
            {
                MessageBox.Show("Konum ve yedek adı giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yedektenDonDosyaSec_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                yedektenDon_textBox.Text = dlg.FileName;
                yedektenAd_textBox.Text = dlg.SafeFileName;
            }
        }

        private void yedektenDon_Button2_Click(object sender, EventArgs e)
        {
            if(yedektenDon_textBox.Text.Length > 0)
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=master;Integrated Security=True");
                Conn.Open();

                try
                {
                    string restoreQuery = "Alter Database vtysProje Set Single_User with rollback immediate; " +
                    "Restore Database vtysProje from disk = '" + yedektenDon_textBox.Text + "' with replace; " +
                    "ALTER DATABASE vtysProje SET MULTI_USER;";
                    Console.WriteLine(restoreQuery);
                    SqlCommand cmd = new SqlCommand(restoreQuery, Conn);                    
                    cmd.ExecuteNonQuery();
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
}
