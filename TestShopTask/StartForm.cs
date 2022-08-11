using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestShopTask
{
    public partial class StartForm : Form
    {
        private string ServerStr = ".\\SQLEXPRESS", DatabaseStr = "Shop",
            UserName = "User1", UserPassword = "123", ErrorMessageStr=null;
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test that the server is connected
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        /// <returns>true if the connection is opened</returns>
        private bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    ErrorMessageStr = null;
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    ErrorMessageStr = ex.Message;
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void openForm(bool initialize, string connectionString)
        {
            if (IsServerConnected(connectionString))
            {
                Form1 newForm = new Form1(initialize, connectionString);
                newForm.Show();
            }
            else
            {
                var result = MessageBox.Show("Ошибка: " + ErrorMessageStr);
            }
        }

        private void getDBParams()
        {
            ServerStr = ServerTB.Text;
            DatabaseStr = DatabaseTB.Text;
            UserName = UsernameTB.Text;
            UserPassword = PasswordTB.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDBParams();

            // User Id={2};Password={3}; если БД предусматривает ввод пароля
            string connectionString =
                string.Format("Server={0};Database=Shop1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework",
                ServerStr, DatabaseStr);
            openForm(true, connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getDBParams();

            // User Id={2};Password={3}; если БД предусматривает ввод пароля
            string connectionString = 
                string.Format("Server={0};Database={1};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework",
                ServerStr, DatabaseStr);
            openForm(false, connectionString);
        }
    }
}
