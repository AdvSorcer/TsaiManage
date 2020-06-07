using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TsaiManage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void check()
        {
            string password = input_pw.Value;
            if (password == "")
            {
                Session.Add("stamp", "non");
                return;
            }
            if (password == "3420551")
            {
                Session.Add("stamp", "ok");
                Response.Redirect("/index.aspx");
            }
        }


        protected void btn_submit_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}