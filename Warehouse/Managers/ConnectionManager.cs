using System.Data.SqlClient;

namespace InventoryApp
{
    public static class ConnectionManager
    {
        private static readonly string connectionString =
            "Data Source=USMAN\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
