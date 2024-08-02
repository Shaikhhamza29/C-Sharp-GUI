using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forEach
{
    public partial class ForEach : System.Web.UI.Page
    {
        private int Fact;

        public void Func() 
        {
            Fact = 1;
            int[] FactArr = {1,2,3,4,5,6};
            foreach (int i in FactArr) 
            {
                Fact *= i;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loop(object sender, EventArgs e)
        {
            ForEach obj = new ForEach();
            obj.Func();
            TextBox1.Text = "The Factorial using foreach : " + obj.Fact.ToString();
        }
    }
}