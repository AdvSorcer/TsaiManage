using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace TsaiManage
{
    public partial class Index : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["stamp"] == null)
            {
                redirect404();
            }
            else
            {
                string id = Session["stamp"].ToString();

                if (id == "ok")
                {
                    connectMysql();
                }
            }
         
        }

        void redirect404()
        {
            Response.Redirect("/relogin.aspx");
        }
        void connectMysql()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            try
            {
                conn.Open();

                String cmdText = "SELECT id, item ,price ,name ,costdate,income from account order by costdate";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader

                DataTable dt = new DataTable();
                dt.Load(reader);

                showRest(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        /// <summary>
        /// 顯示餘額
        /// </summary>
        void showRest(DataTable dt)
        {
            int income=0;
            int price = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                income += (int)dt.Rows[i]["income"];
                price += (int)dt.Rows[i]["price"];
            }

            int rest = income - price;

            Lit_rest.Text = rest.ToString();
        }

        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "up")
            {

                int rowIndex = int.Parse(e.CommandArgument.ToString());
                string id = GridView1.DataKeys[rowIndex][0].ToString();

                Response.Redirect($"/Edit.aspx?SN={id}");

            }
        }
    }
}