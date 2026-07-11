using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;

namespace SmartMedPharmacy.Models
{
    public interface IReport
    {
        DataTable GetSalesReport();
        DataTable GetStockReport();
        DataTable GetCustomerOrderHistory(int customerId);

        
    }

}
