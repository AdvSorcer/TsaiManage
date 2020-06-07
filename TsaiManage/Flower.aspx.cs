using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace TsaiManage
{
    public partial class Flower : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectMysql();
        }

        void connectMysql()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            try
            {
                conn.Open();

                String cmdText = "SELECT * from flower order by send_date";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader

                DataTable dt = new DataTable();
                dt.Load(reader);

                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }


        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "up")
            {

                int rowIndex = int.Parse(e.CommandArgument.ToString());
                string id = GridView1.DataKeys[rowIndex][0].ToString();

                Response.Redirect($"/CreateFlower.aspx?SN={id}&mode=edit");

            }
        }
    }
}