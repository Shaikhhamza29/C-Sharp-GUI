using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsOver
{
    public partial class ConsOver : System.Web.UI.Page
    {
        //int a, b;
        int result;
        int result1;
        public ConsOver()
        {
        }
        public ConsOver(int a , int b) 
        {
            result = a + b;
        }
        public ConsOver(int a , int b , int c)
        {
            result1 = a + b + c;
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsOver obj = new ConsOver(10,20);
            TextBox1.Text = "Constructor with two parameter : "+obj.result.ToString();
            ConsOver obj1 = new ConsOver(10,20,30);
            TextBox2.Text = "Constructor with three parameter : "+obj1.result1.ToString();
        }
    }

}