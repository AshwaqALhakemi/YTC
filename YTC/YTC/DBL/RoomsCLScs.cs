using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YTC.DBL
{
    class RoomsCLScs
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        public DataTable GET_ALL_ROOMSTYPE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_ROOMSTYPE", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_FLOORSNAMES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_FLOORSNAMES", null);
            DAL.close();
            return Dt;

        }

        public DataTable GET_ROOMS_DESCS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ROOMS_DESC", null);
            DAL.close();
            return Dt;
        }

        public DataTable GET_ALL_ROOMS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_ROOMS", null);
            DAL.close();
            return Dt;
        }
        public void ADD_ROOMS (string F_name, string R_Type, string R_NO ,string R_desc,string R_Quantity, bool IsReserved)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = F_name;
            param[1] = new SqlParameter("@R_Type", SqlDbType.VarChar, 50);
            param[1].Value = R_Type;
            param[2] = new SqlParameter("@R_NO", SqlDbType.VarChar, 50);
            param[2].Value = R_NO;
            param[3] = new SqlParameter("@R_desc ", SqlDbType.VarChar, 50);
            param[3].Value = R_desc;
            param[4] = new SqlParameter("@R_Quantity ", SqlDbType.VarChar, 50);
            param[4].Value = R_Quantity;
            param[5] = new SqlParameter("@IsReserved ", SqlDbType.Bit);
            param[5].Value = IsReserved;
            DAL.Open();
            DAL.ExecuteCommand("ADD_ROOMS", param);
            DAL.close();
        }

        public void ROOMS_EDIT(string F_name, string R_Type, string R_NO, string R_desc, string R_Quantity, bool IsReserved)
        {


             SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = F_name;
            param[1] = new SqlParameter("@R_Type", SqlDbType.VarChar, 50);
            param[1].Value = R_Type;
            param[2] = new SqlParameter("@R_NO", SqlDbType.VarChar, 50);
            param[2].Value = R_NO;
            param[3] = new SqlParameter("@R_desc ", SqlDbType.VarChar, 50);
            param[3].Value = R_desc;
            param[4] = new SqlParameter("@R_Quantity ", SqlDbType.VarChar, 50);
            param[4].Value = R_Quantity;
            param[5] = new SqlParameter("@IsReserved ", SqlDbType.Bit);
            param[5].Value = IsReserved;
            DAL.Open();
           
            DAL.Open();
            DAL.ExecuteCommand("ROOMS_EDIT", param);
            DAL.close();
        }
        public void DELETE_ROOMS(string R_NO)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@R_NO", SqlDbType.VarChar, 50);
            param[0].Value = R_NO;

            DAL.Open();
            DAL.ExecuteCommand("DELETE_ROOMS", param);
            DAL.close();

        }
        public DataTable SEARCH_ROOMS(string F_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = F_name;
            Dt = DAL.SelectData("SEARCH_ROOMS", param);
            DAL.close();
            return Dt;



        }




    }
}
