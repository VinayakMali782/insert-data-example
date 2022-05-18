using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace insert_data_example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source='VINAYAKMALI\\MSSQLSERVER04';Initial Catalog=vinayak;Integrated Security=True"); //,user=; password


            //con.Open();
            //string query = "insert into tbl_emp values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //Label1.Text = "Record Inserted Successfully ";
            con.Open();
            string sql = "insert Into tbl_emp Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(sql,con);
            int i=cmd  .ExecuteNonQuery();  
            con.Close();
            Label1.Text = "recordes Saved SucessFully";

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source='VINAYAKMALI\\MSSQLSERVER04';Initial Catalog=vinayak;Integrated Security=True");
            con.Open();
            string sql = "Delete from tbl_emp Where salary='"+ TextBox3.Text + "'";//.
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "recordes  (inserted) Saved SucessFully";


            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
        }

    }
}


//        string connectionstring = "DataSource=severname;InitialCatlog=databasename;Uid=; password=;"SqlConnection con = new SqlConnection(connectionstring)
