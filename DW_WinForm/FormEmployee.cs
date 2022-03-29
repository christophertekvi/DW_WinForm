using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DW_WinForm
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        MySqlDataAdapter sqlDataAdapter;
        public MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        string sqlQuery;
        DataTable dtRandom = new DataTable();
        string[] namaDepan = { "Udin", "Asep" ,"Jono", "Christopher", "Johan", "Tito", "Briaan", "Cliffton", "Yohan", "Buaya"};

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.ConnectionString = "server = 139.255.11.84; uid = student; pwd = isbmantap; database = DW_TITO_OLTP1;";
                for (int i = 0; i < 50; i++)
                {
                    Random random = new Random();
                    int rdmIndex = random.Next(0, 10);

                    sqlQuery = "select  ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
