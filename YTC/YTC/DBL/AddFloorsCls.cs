using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YTC.DBL
{
    class AddFloorsCls
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


        public void ADD_Floors(string fNAME, string Fdesc)
        {
            

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = fNAME;
            param[1] = new SqlParameter("@F_Desc", SqlDbType.VarChar, 50);
            param[1].Value = Fdesc;
            DAL.Open();
            DAL.ExecuteCommand("SP_ADDFLOORS", param);
            DAL.close();


        }


        public DataTable VerifyFloorsName(string F_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = F_name;

            DAL.Open();
            
            Dt = DAL.SelectData("VerifyFloorsName", param);
            DAL.close();
            return Dt;


        }
        public DataTable GET_ALL_FLOORS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();

            Dt = DAL.SelectData("GET_ALL_FLOORS", null);
            DAL.close();
            return Dt;


        }
        public DataTable SearchFloors(string F_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = F_name;

            

            Dt = DAL.SelectData("SearchFloors", param);
            DAL.close();
            return Dt;


        }

        public void DeleteFloors (string fNAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@F_name", SqlDbType.VarChar, 50);
            param[0].Value = fNAME;

            DAL.Open();
            DAL.ExecuteCommand("DeleteFloors", param);
            DAL.close();


        }


    }


}