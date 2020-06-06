using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace TsaiManage
{
    public partial class Create : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            string item = tbx_item.Text;
            string income = tbx_income.Text;
            string price = tbx_price.Text;
            string name = tbx_name.Text;
            string costdate = tbx_date.Text;
            DateTime now = DateTime.Now;

            string cmdText = $@"insert into account(item,income,price,name,costdate)
                                values('{item}','{income}','{price}','{name}','{costdate}')";


            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            
            //Response.Write(cmdText);
            try
            {
                conn.Open();
                command.CommandText = cmdText;
                command.ExecuteNonQuery();
                Response.Redirect("/Index.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("fail");
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Index.aspx");
        }
    }
}