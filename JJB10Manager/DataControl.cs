using JJB10Manager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace JJB10Manager
{
    public class DataControl
    {
        #region ----Users----
        
        public static List<Users> GetAllUsers()
        {
            List<Users> allUsers = new List<Users>();

            Users user;
            string sqlStr = "Select * from Users";
            DataTable dt = AccessHelper.runDt(sqlStr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user = new Users();
                user.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                user.UserCode = dt.Rows[i]["UserCode"].ToString();
                user.UserName = dt.Rows[i]["UserName"].ToString();
                user.MAC = dt.Rows[i]["MAC"].ToString();
                user.Timer = Convert.ToDateTime(dt.Rows[i]["Timer"]);

                allUsers.Add(user);
            }

            return allUsers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="type">0新增，1修改</param>
        /// <returns></returns>
        public static bool AddOrUpdateUsers(Users user, int type,ref string msg)
        {
            string sqlStr = "";
            if (type == 0)
            {
                if (IsExit("MAC", user.MAC, "Users"))
                {
                    msg = "此MAC已分配给其他人";
                    return false;
                }
                sqlStr = "Insert into Users(UserCode,UserName,MAC,Timer) values('"
                    + user.UserCode + "','"
                    + user.UserName + "','"
                    + user.MAC + "','"
                    + user.Timer.ToString("yyyy-MM-dd HH:mm:ss") + "') ";
            }
            else
            {
                sqlStr = "Update Users Set MAC = '" + user.MAC
                    + "',UserName = '" + user.UserName
                    + "' where  Id= " + user.ID;
            }

            if (AccessHelper.runSql(sqlStr) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteUsersById(string id)
        {
            string sqlStr = "Delete from Users where id = " + id;
            if (AccessHelper.runSql(sqlStr) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Users GetUserById(string id)
        {
            Users user = new Users();
            string sqlStr = "Select * from Users where id = " + id;
            DataTable dt = AccessHelper.runDt(sqlStr);
            if (dt.Rows.Count > 0)
            {
                user = new Users();
                user.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                user.UserCode = dt.Rows[0]["UserCode"].ToString();
                user.UserName = dt.Rows[0]["UserName"].ToString();
                user.MAC = dt.Rows[0]["MAC"].ToString();
                user.Timer = Convert.ToDateTime(dt.Rows[0]["Timer"]);
            }

            return user;
        }

        public static Users GetUserByMac(string mac)
        {
            Users user = new Users();
            string sqlStr = "Select * from Users where MAC = '" + mac + "'";
            DataTable dt = AccessHelper.runDt(sqlStr);
            if (dt.Rows.Count > 0)
            {
                user = new Users();
                user.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                user.UserCode = dt.Rows[0]["UserCode"].ToString();
                user.UserName = dt.Rows[0]["UserName"].ToString();
                user.MAC = dt.Rows[0]["MAC"].ToString();
                user.Timer = Convert.ToDateTime(dt.Rows[0]["Timer"]);
            }

            return user;

            return user;
        }

        #endregion

        #region ----Data----

        public static void InsertIntoData(Data data)
        {
            string sqlStr = "Delete from Data where Timer = #" + data.Timer.ToString("yyyy-MM-dd HH:mm:ss") + "#";
            AccessHelper.runSql(sqlStr);

            sqlStr = "Insert into Data(IP,MAC,Place,Timer,RealValue,UpTime) values('"
                + data.IP + "','"
                + data.MAC + "','"
                + data.Place + "','"
                + data.Timer + "','"
                + data.RealValue + "','"
                + data.UpTime + "')";
            AccessHelper.runSql(sqlStr);
        }

        public static List<Data> GetDataByDate(DateTime date)
        {
            List<Data> Datas = new List<Data>();

            string stime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            string etime = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59).ToString("yyyy-MM-dd HH:mm:ss");
            string sqlStr = "Select * from Data where Timer >= #" + stime + "# and Timer <= #" + etime + "# ";
            DataTable dt = AccessHelper.runDt(sqlStr);
            Data data;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = new Data();
                data.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                data.IP = dt.Rows[i]["IP"].ToString();
                data.MAC = dt.Rows[i]["MAC"].ToString();
                data.Place = dt.Rows[i]["Place"].ToString();
                data.Timer = Convert.ToDateTime(dt.Rows[i]["Timer"]);
                data.RealValue = Convert.ToDouble(dt.Rows[i]["RealValue"]);
                data.UpTime = Convert.ToDateTime(dt.Rows[i]["UpTime"]);

                Datas.Add(data);
            }
            return Datas;
        }


        public static Data GetDataFromReciveStr(string recStr)
        {
            Data data = new  Data();
            try
            {
                string temp = recStr.Substring(0, 12);

                temp = temp.Insert(10, ".").Insert(8, ".").Insert(6, ".").Insert(4, ".").Insert(2, ".");

                data.MAC = temp;
                temp = DateTime.Now.ToString("yyyy-MM-dd") + " " + recStr.Substring(recStr.Length - 8, 8);
                data.UpTime = Convert.ToDateTime(temp);

                temp = recStr.Substring(recStr.Length - 15, 7);
                data.RealValue = Convert.ToDouble(temp);

                temp = recStr.Substring(recStr.Length - 34, 19);
                data.Timer = Convert.ToDateTime(temp);

                data.Place = recStr.Substring(12, recStr.Length - 46);
            }
            catch (Exception ex)
            {
                data = null;
            }
            return data;
        }
             
        #endregion
        public static bool IsExit(string fildName, string fildValue, string tableName)
        {
            string sqlStr = "Select " + fildName + " from " + tableName + " where " + fildName + " = '" + fildValue + "'";
            DataTable dt = AccessHelper.runDt(sqlStr);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString().Trim() != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

