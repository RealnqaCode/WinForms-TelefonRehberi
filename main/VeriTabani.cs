using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public class VeriTabani
    {
        private MySqlConnection connection;

        public VeriTabani(string server, string database, string user, string password, string port)
        {
            string connectionString = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection => connection;

        public void Connect()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Bağlantı kapatılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
