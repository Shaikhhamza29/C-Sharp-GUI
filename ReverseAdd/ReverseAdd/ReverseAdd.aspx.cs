using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReverseAdd
{
    public partial class ReverseAdd : System.Web.UI.Page
    {
        private int num,rev = 0,rem,sum = 0;
        public void rev_num() 
        {
            while (num>0) 
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                sum = sum + rem;
                num = num / 10;
            }

        }

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReverseAdd obj = new ReverseAdd();
            obj.num = System.Convert.ToInt32(TextBox1.Text);
            obj.rev_num();
            TextBox2.Text = "Reverse Number : " + obj.rev.ToString(); 

            TextBox3.Text = "Sum Number : " + obj.sum.ToString();
        }
    }
}