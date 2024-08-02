using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        private int a, b, c, d;
        private int result;
        protected int product()
        {
            result = a * b * c * d;
            return result;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Product(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.a = System.Convert.ToInt32(TextBox1.Text);
            obj.b = System.Convert.ToInt32(TextBox2.Text);
            obj.c = System.Convert.ToInt32(TextBox3.Text);
            obj.d = System.Convert.ToInt32(TextBox4.Text);

            TextBox5.Text = "Result Is :" + obj.product().ToString(); 

        }
    }
}