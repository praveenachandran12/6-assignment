using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASSIGNMENT6.DAL
{
    public class desDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public desDAL()
        {



            string conn = ConfigurationManager.ConnectionStrings["ros"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public DataTable Getdept(BAL.desBAL obj)
        {
            string s = "SELECT * FROM department";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insertdesign(BAL.desBAL obj)
        {
            string qry = "insert into designation values('" + obj._designation + "','" + obj._deptid + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }


        public int desgUpdate(BAL.desBAL obj)
        {
            string s = "update designation set designationname='" + obj._designation + "' where designationid='" + obj._desid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }



        public int Deletedesig(BAL.desBAL obj)
        {
            string s = "delete from designation where designationid='" + obj._desid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable desigview(BAL.desBAL obj)
        {
            string s = "select * from designation td inner join department dt on td.depid=dt.depid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}