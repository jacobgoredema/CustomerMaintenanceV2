using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceV2
{
    public class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=JHB-JACOBGOREDE\\SQLEXPRESS;Initial Catalog=MMABook;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
