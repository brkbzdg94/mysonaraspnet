using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySonarASP
{
    public partial class SonarForm : System.Web.UI.Page
    {
        int sayi = 0;
        int a;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "SonarQube e hoş geldiniz.";
        }
    }
}