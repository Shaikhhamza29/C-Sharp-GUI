using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Conversion
{
    public partial class Conversion : System.Web.UI.Page
    {
        private int amount;
        private double result;
        private double result_d;
        public void Func()
        {
            result = amount * 83.74;
            result_d = amount / 83.74;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Money(object sender, EventArgs e)
        {
            Conversion obj = new Conversion();
            obj.amount = System.Convert.ToInt32(TextBox1.Text);
            obj.Func();
            TextBox2.Text = "The Conversion of INR To Dollar :  " + obj.result_d.ToString();
            TextBox3.Text = "The Conversion of Dollar TO INR :  " + obj.result.ToString(); 
        }
    }
}