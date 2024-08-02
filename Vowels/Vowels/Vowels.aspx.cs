using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vowels
{
    public partial class Vowels : System.Web.UI.Page
    {
        private char ch;
        private int a;
        protected int vowels_not()
        {
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                a = 1;
            }
            return a;
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Vowels obj = new Vowels();
            obj.ch = System.Convert.ToChar(TextBox1.Text);
            a = obj.vowels_not();
            if (a == 1)
            {
                TextBox2.Text = obj.ch + "  It Is a Vowel ";
            }
            else
            {
                TextBox2.Text = obj.ch + "  It Is a Consonant";
            }
        }
    }
}