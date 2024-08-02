using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FibonacciSeries
{
    public partial class Fibonacci : System.Web.UI.Page
    {
        private int a, b,input, sum;

        public String fibonacci()
        {
            a = 0;
            b = 1;
            string s = System.Convert.ToString(a+  "\t" +b);
            for (int i = 2; i < input; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                s = System.Convert.ToString(s + "\t" +sum);
               
            }
            return s;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Fibonacci_Series(object sender, EventArgs e)
        {
            Fibonacci obj = new Fibonacci();
            obj.input = System.Convert.ToInt32(TextBox1.Text);
            TextBox2.Text = obj.fibonacci(); 

    
        }
    }
}