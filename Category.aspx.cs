using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Product_Management_System
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid, cname,Productid,Productname;
            cid = TextBox1.Text;
            cname = TextBox2.Text;
            Productid =Convert.ToString(Session["Pid"]);
            Productname = Convert.ToString(Session["Pname"]);

            string sql;
            sql = "Data Source=GAURAV-PC\\SQLEXPRESS;Initial Catalog=Product DBMS;Integrated Security=true;";

            SqlConnection con = new SqlConnection(sql);

            con.Open();

            string cmd;

            cmd="insert into ProductList(ProductID,ProductName,CategoryID,CategoryName)values('"+Productid+"','"+Productname+"','"+cid+"','"+cname+"')";

            SqlCommand s1=new SqlCommand(cmd, con);

           
            int x=s1.ExecuteNonQuery();

            if (x > 0) 
            {
                Response.Write("<script>");
                Response.Write("alert('Record Saved')");
                Response.Write("</script>");
                Response.Redirect("Product.aspx");
                
            }
            else
            {
                Response.Write("<script>");
                Response.Write("alert('Failed to Saved')");
                Response.Write("</script>");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }
    }
}