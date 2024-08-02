using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Factorial
{
    public partial class Factorial : System.Web.UI.Page
    {
        private int fact = 1,no;
        private void factorial_no() 
        {
            for (int i = 1; i <= no; i++) 
            {
                fact *= i;

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FactResult(object sender, EventArgs e)
        {
            Factorial obj = new Factorial();
            obj.no = System.Convert.ToInt32(TextBox1.Text);
            obj.factorial_no();
            TextBox2.Text =" The Factorial of Number is : "+ obj.fact.ToString();
        }
    }
}