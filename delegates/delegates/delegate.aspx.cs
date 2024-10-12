using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace delegates
{
    public partial class _delegate : System.Web.UI.Page
    {
        delegate void AdditionCall(int no,int no1);
        delegate void subtractionCall(int no1,int no2);
        Label title, inputlb, outputadd,outputsub;
        TextBox inputtxt1,inputtxt2;
        Button result;


        protected void Page_Load(object sender, EventArgs e)
        {
            title = new Label() { Text = "ADDITION & SUBTRACTION USING DELEGATES"};
            inputlb = new Label() { Text = "Enter two number : " };
            inputtxt1 = new TextBox();
            inputtxt2 = new TextBox();
            result = new Button() { Text = "RESULT "};
            outputadd = new Label();
            outputsub = new Label();


            this.form1.Controls.Add(title);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(inputlb);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(inputtxt1);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(inputtxt2);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(result);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(outputadd);
            this.form1.Controls.Add(new LiteralControl("<br>"));
            this.form1.Controls.Add(outputsub);

            result.Click += AddSub;

       }
       protected void AddSub(object sender, EventArgs e) 
       {
           int num1 = System.Convert.ToInt32(inputtxt1.Text);
           int num2 = System.Convert.ToInt32(inputtxt2.Text);
           AdditionCall add = new AdditionCall(Addition);

           subtractionCall sub = new subtractionCall(Subtraction);
           add(num1,num2);
           sub(num1,num2);
       }

       public void Addition(int no1, int no2)
       {
           int numresult = no1 + no2;
           outputadd.Text = "THE ADDITION OF TWO NUMBER IS : " + numresult.ToString(); ;
       }
       public void Subtraction(int no1, int no2)
       {
           int numresult = no1 - no2;
           outputsub.Text = "THE SUBTRACTION OF TWO NUMBER IS : " + numresult.ToString(); ;
       }
    }
}