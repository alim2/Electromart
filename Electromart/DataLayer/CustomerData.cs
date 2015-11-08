using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EntityLayer;

namespace DataLayer
{
    public class CustomerData
    {
        public Dictionary<string, object> GetCatProduct(int cat, string conString)
        {
            List<ProductInfo> pList = new List<ProductInfo>();
            Dictionary<string, object> objects;
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = cat != 0 ? $"SELECT * FROM PRODUCTS WHERE CAT_ID = {cat}" : "SELECT * FROM PRODUCTS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet products = new DataSet();
                adapter.Fill(products, "Products");
                products.Tables["Products"].PrimaryKey = new[] { products.Tables["Products"].Columns["PID"] };
                objects = new Dictionary<string, object>()
                {
                    {"products", products},
                    {"adapter", adapter}
                };
            }
            return objects;


        }
    }
}
