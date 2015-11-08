using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;

namespace Electromart
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetNewTopProduct();
            }

            MultiView1.ActiveViewIndex = 0;
        }

        private void GetNewTopProduct()
        {
            if (Session["Products"] != null)
            {
                DataSet products = (DataSet)Session["Products"];
                ProductList(products, "All Product");
                Response.Write("session");
                return;
            }
            string conString = ConfigurationManager.ConnectionStrings["ElectromartDB"].ConnectionString;
            var dictionary2 = new CustomerData().GetCatProduct(0, conString);
            foreach (var value in dictionary2)
            {
                DataSet products = (DataSet)value.Value;
                ProductList(products, "All Product");
                Session["Products"] = products;
                Response.Write("db");
                break;
            }
        }

        protected void BtnTv_OnClick(object sender, ImageClickEventArgs e)
        {

            string id = ((ImageButton)sender).ID;
            string conString = ConfigurationManager.ConnectionStrings["ElectromartDB"].ConnectionString;
            switch (id)
            {
                case "BtnTv":
                    var dictionary1 = new CustomerData().GetCatProduct(3, conString);
                    foreach (var value in dictionary1)
                    {
                        //GridView1.DataSource = (DataSet)val.Value;
                        //GridView1.DataBind();
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
                case "BtnLaptop":
                    var dictionary2 = new CustomerData().GetCatProduct(2, conString);
                    foreach (var value in dictionary2)
                    {
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
                case "BtnMonitor":
                    var dictionary3 = new CustomerData().GetCatProduct(5, conString);
                    foreach (var value in dictionary3)
                    {
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
                case "BtnMobile":
                    var dictionary4 = new CustomerData().GetCatProduct(6, conString);
                    foreach (var value in dictionary4)
                    {
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
                case "BtnCamera":
                    var dictionary5 = new CustomerData().GetCatProduct(7, conString);
                    foreach (var value in dictionary5)
                    {
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
                case "BtnAccessories":
                    var dictionary6 = new CustomerData().GetCatProduct(8, conString);
                    foreach (var value in dictionary6)
                    {
                        DataSet products = (DataSet)value.Value;
                        ProductList(products, "Category Product");
                        break;
                    }
                    break;
            }
            MultiView1.ActiveViewIndex = 1;
        }

        private void ProductList(DataSet products, string type)
        {
            string product = "<table class=\"table-responsive\"> <tr> ";
            int count = 0;
            foreach (DataRow tv in products.Tables["Products"].Rows)
            {
                count++;
                product += "<td><div><input type=\"image\" src=\"submit.gif\" alt=\"pic missing\"  onclick=\"return myfunc("+ tv["PID"] + ")\""
                           + "\" /><br/><label>" + tv["PNAME"] + "&nbsp&nbsp&nbsp" + "</label></div></td>";
                if (count % 8 == 0)
                {
                    product += "</tr> <tr>";
                }
            }
            product += "</tr> </table>";
            if (type == "All Product")
            {
                NewProductDiv.InnerHtml = product;
                TopProductDiv.InnerHtml = product;
            }

            else
                CategoryProducts.InnerHtml = product;
        }

    }
}