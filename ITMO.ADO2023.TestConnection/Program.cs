using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace ITMO.ADO2023.TestConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = ApressFinancial; Data Source = BLACK-CRYSTAL\\SQLEXPRESS"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT [CustomerFinancialProductID],[CustomerId],[LastCollection] FROM [CustomerDetails].[CustomersProducts]", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["CustomerFinancialProductID"]);
                        }
                    }
                }
            }
        }
    }
}
