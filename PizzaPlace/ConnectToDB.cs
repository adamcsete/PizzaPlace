using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace PizzaPlace
{
    public partial class ConnectToDB : Form
    {
        public ConnectToDB()
        {
            InitializeComponent();
            dbsourcefile.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\place");
        }

        private void csatlakozas_Click(object sender, EventArgs e)
        {
            string dbparampath = dbsourcefile.Text;
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\place", dbsourcefile.Text);
            string ConnectionString = File.ReadAllText(dbparampath);
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();
                File.WriteAllText("dbparameter", ConnectionString);
                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen csalatkozás: " + ex.Message);
            }

        }

    }
}
