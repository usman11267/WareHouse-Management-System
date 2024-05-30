using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Views
{
    public static class ConnectionString
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=USMAN\\SQLEXPRESS;Initial Catalog=dbproj;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return new SqlConnection(connectionString);
        }
    }
}
