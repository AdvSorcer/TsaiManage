using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace TsaiManage
{
    public partial class CreateFlower : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        void initEdit(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            String cmdText = $"SELECT * from flower where id ={id}";
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            MySqlDataReader reader = cmd.ExecuteReader(); //execure the reader

            DataTable dt = new DataTable();
            dt.Load(reader);

            string item = dt.Rows[0]["object"].ToString();
            string count = dt.Rows[0]["count"].ToString();
            string who = dt.Rows[0]["who"].ToString();
            string send_date = dt.Rows[0]["send_date"].ToString();

            tbx_item.Text = item;
            tbx_count.Text = count;
            tbx_who.Text = who;
            tbx_date.Text = send_date;

        }


        protected void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["mode"]))
            {
                string mode = Request.QueryString["mode"];
                if (mode == "create")
                {
                    Add();
                }
                if (mode == "edit")
                {
                    Update();
                }
            }
            
            Add();
        }
        void Add()
        {
            string item = tbx_item.Text;
            string count = tbx_count.Text;
            string who = tbx_who.Text;
            string send_date = tbx_date.Text;
            DateTime now = DateTime.Now;

            string cmdText = $@"insert into flower(object,count,who,send_date)
                                values('{item}','{count}','{who}','{send_date}')";


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
            catch (Exception ex)
            {
                Response.Write("fail");
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        void Update()
        {
            string item = tbx_item.Text;
            string count = tbx_count.Text;
            string who = tbx_who.Text;
            string send_date = tbx_date.Text;
            DateTime now = DateTime.Now;

            string sid = Request.QueryString["SN"];

            if (sid == "")
            {
                return;
            }

            string cmdText = $@"update tsai.flower
                                 set object='{item}',count='{count}',who='{who}',send_date='{send_date}' where id={sid}";

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
            catch (Exception ex)
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
            Response.Redirect("/Flower.aspx");
        }
    }
}