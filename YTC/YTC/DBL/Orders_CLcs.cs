using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace YTC.DBL
{
    
    class Orders_CLcs
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        public DataTable GET_LAST_ORDERID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDERID", null);
            DAL.close();
            return Dt;
        }
        public void ADD_ORDER(string Order_Id, string Reversed_Date, string Order_Price, string First_Payed, string Last_Payed, string Duration, string Cancel_Date,
          string NumberofPepole, string OrderReson, string F_name , string R_NO ,string C_ID,bool IsCancel)
        {

            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@Order_Id", SqlDbType.VarChar, 50);
            param[0].Value = Order_Id;
            param[1] = new SqlParameter("@Reversed_Date", SqlDbType.VarChar, 50);
            param[1].Value = Reversed_Date;
            param[2] = new SqlParameter("@Order_Price", SqlDbType.VarChar, 50);
            param[2].Value = Order_Price;
            param[3] = new SqlParameter("@First_Payed", SqlDbType.VarChar, 50);
            param[3].Value = First_Payed;
            param[4] = new SqlParameter("@Last_Payed", SqlDbType.VarChar, 50);
            param[4].Value = Last_Payed;
            param[5] = new SqlParameter("@Duration", SqlDbType.VarChar, 50);
            param[5].Value = Duration;
            
            param[6] = new SqlParameter("@Cancel_Date", SqlDbType.VarChar, 50);
            param[6].Value = Cancel_Date;
            param[7] = new SqlParameter("@NumberofPepole", SqlDbType.VarChar, 50);
            param[7].Value = NumberofPepole;

            param[8] = new SqlParameter("@OrderReson", SqlDbType.VarChar, 50);
            param[8].Value = OrderReson;
            param[9] = new SqlParameter("@ F_name", SqlDbType.VarChar, 50);
            param[9].Value = F_name;
            param[10] = new SqlParameter("@R_NO", SqlDbType.VarChar, 50);
            param[10].Value = R_NO;
            param[11] = new SqlParameter("@C_ID", SqlDbType.VarChar, 50);
            param[11].Value = C_ID;
            param[12] = new SqlParameter("@IsCancel", SqlDbType.Bit, 50);
            param[12].Value = IsCancel;


            DAL.Open();
            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.close();
        }





    }
}
