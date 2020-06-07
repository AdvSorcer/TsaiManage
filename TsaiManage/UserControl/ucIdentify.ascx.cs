using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TsaiManage.UserControl
{
    public partial class ucIdentify : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            check();
        }

        void check()
        {
            if (Session["stamp"] == null)
            {
                redirect404();
            }

            if (Session["stamp"].ToString() != "ok")
            {
                redirect404();
            }

        }
        void redirect404()
        {
            Response.Redirect("/relogin.aspx");
        }
    }
}