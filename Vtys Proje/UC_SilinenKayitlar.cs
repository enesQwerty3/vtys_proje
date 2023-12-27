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
    public partial class UC_SilinenKayitlar : UserControl
    {
        public UC_SilinenKayitlar()
        {
            InitializeComponent();
            SilinenKayıtlarıListele();
        }

        private void SilinenKayıtlarıListele()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=vtysProje;Integrated Security=True");
            Conn.Open();

            try
            {
                string selectQuery = "SELECT DISTINCT * FROM SilinenUyeler";
                SqlDataAdapter sda = new SqlDataAdapter(selectQuery, Conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                silinenUyeler_dataGridView.DataSource = dataTable;
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
