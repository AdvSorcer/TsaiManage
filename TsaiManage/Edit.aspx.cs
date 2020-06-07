using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;

namespace TsaiManage
{
    public partial class Edit : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sid = Request.QueryString["SN"];

                if (!string.IsNullOrEmpty(sid))
                {
                    init(sid);
                }
            }
            
        }

        void init(string id)
        {
          
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            String cmdText = $"SELECT * from account where id ={id}";
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader

            DataTable dt = new DataTable();
            dt.Load(reader);

            string item = dt.Rows[0]["item"].ToString();
            string income = dt.Rows[0]["income"].ToString();
            string price = dt.Rows[0]["price"].ToString();
            string name = dt.Rows[0]["name"].ToString();
            string costdate = dt.Rows[0]["costdate"].ToString();

            tbx_item.Text = item;
            tbx_income.Text = income;
            tbx_price.Text = price;
            tbx_name.Text = name;
            tbx_date.Text = costdate;

        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            string item = tbx_item.Text;
            string income = tbx_income.Text;
            string price = tbx_price.Text;
            string name = tbx_name.Text;
            string costdate = tbx_date.Text;
            DateTime now = DateTime.Now;

            string sid = Request.QueryString["SN"];

            if (sid == "")
            {
                return;
            }

            string cmdText = $@"update tsai.account
                                 set item='{item}',income='{income}',price='{price}',name='{name}',costdate='{costdate}' where id={sid}";

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

                Response.Write(cmdText);
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