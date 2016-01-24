using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Label2.Visible = True;
   Label2.Text = "Welcome to Tutorials Point: " + TextBox1.Text;
   Label1.Text = "You visited us at: " + DateTime.Now.ToString();
        }
    }
}