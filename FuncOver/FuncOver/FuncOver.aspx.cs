using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FuncOver
{
    public partial class FuncOver : System.Web.UI.Page
    {
        int result;
        double result_d; 
        public void Multiply(int a, int b)
        {
            result = a * b;
 
        }

        public void Multiply(double a, double b)
        {
            result_d = a * b;

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Result(object sender, EventArgs e)
        {
            FuncOver obj = new FuncOver();
            obj.Multiply(2, 5);
            TextBox3.Text = "Multiplication of Integer  : "+ obj.result.ToString();
            obj.Multiply(3.10D, 5.0D);
            TextBox4.Text = "Multiplication of Double  : " + obj.result_d.ToString();
        }
    }
}