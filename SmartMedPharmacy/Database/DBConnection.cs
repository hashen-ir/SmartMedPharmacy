using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMedPharmacy.Database
{
    public class DBConnection
    {
        private string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=SmartMedPharmacy;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
