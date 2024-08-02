using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeNumbers
{
    public partial class PrimeNumbers : System.Web.UI.Page
    {
        private int n,a;
        public int numbers()
        {
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
               
            }
          
            return a;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PrimeNumbers obj = new PrimeNumbers();
            obj.n = System.Convert.ToInt32(TextBox1.Text);
            a = obj.numbers();
            if (a >= 2)
            {
               TextBox2.Text = " It is a not Prime Number";
            }
            else
            {
               TextBox2.Text = " It is a Prime Number";
            }
        }

        
    }
}