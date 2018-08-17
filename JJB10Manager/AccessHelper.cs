using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace JJB10Manager
{
    class AccessHelper
    {
        public static string connStr = "";
        public static DataTable runDt(string cmdText)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection con = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand(cmdText, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    OleDbDataReader adr = cmd.ExecuteReader();
                    dt.Load(adr);
                }
                catch (Exception ex)
                {
                }
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                Win32.WriteLogFile("【runDt】-" + ex.Message + "|" + cmdText);
            }
            return dt;
        }
        public static int runSql(string cmdText)
        {
            int x = -1;
            try
            {
                OleDbConnection con = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand(cmdText, con);
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    x = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Win32.WriteLogFile("【runSql1】-" + ex.Message + "|" + cmdText);
                }
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                Win32.WriteLogFile("【runSql2】-" + ex.Message + "|" + cmdText);
            }
            return x;
        }
    }
}
