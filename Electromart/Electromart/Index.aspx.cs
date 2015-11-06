using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electromart
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello");
            Response.Write("test by shawon");
            Response.Write("test by mohim");
        }
        public void Test()
        {
            Response.Write("hello cat");
        }
    }
}