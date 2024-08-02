using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Of_Four
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string a, b, c, d;
        private int a1 ,b1 ,c1 ,d1;
        private int Result;
        public void Product(int a, int b, int c, int d)
        {
            Result = a * b * c * d;
            TextBox5.Text = "Result is "+ Result.ToString(); 
        }


 
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebForm1 obj = new WebForm1();
            obj.a = TextBox1.Text;
            obj.b = TextBox1.Text;
            obj.c = TextBox1.Text;
            obj.d = TextBox1.Text;
            obj.a1 = Convert.ToInt32(a);
            obj.b1 = Convert.ToInt32(b);
            obj.c1 = Convert.ToInt32(c);
            obj.d1 = Convert.ToInt32(d);
            obj.Product(obj.a1, obj.b1, obj.c1, obj.d1);
        }
    }
}