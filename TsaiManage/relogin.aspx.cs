﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TsaiManage
{
    public partial class relogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_reload_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/Login.aspx");
        }
    }
}