using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Management_System
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Pid"] = TextBox3.Text;
            Session["Pname"] = TextBox4.Text;

            Response.Redirect("Category.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
           
            Response.Redirect("ProductDatabase.aspx");
        }

    }
}