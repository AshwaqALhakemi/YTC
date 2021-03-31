using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YTC.DBL
{
    class LOGIN_CLS
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public DataTable LOGIN(string ID, string PassWord)
        {
            
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
            param[1].Value = PassWord;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.close();
            return Dt;


        }

        public void USER_ADD(string ID, string UserFullName, string Password, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 50);
            param[1].Value = UserFullName;
            param[2] = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
            param[2].Value = Password;
            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;
            
            DAL.Open();
            DAL.ExecuteCommand("USER_ADD", param);
            DAL.close();


        }
    }
}
