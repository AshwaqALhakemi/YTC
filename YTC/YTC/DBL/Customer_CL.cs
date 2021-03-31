using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YTC.DBL
{
    class Customer_CL
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public void ADD_CUSTOMERS(string C_ID, string C_idType, string C_Fname , string C_Sname, string C_Tname, string C_Lname, string C_Nationality ,
          string C_Job,   string C_WorkOrganization, string C_Phone )
        {

            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@C_ID", SqlDbType.VarChar, 50);
            param[0].Value = C_ID;
            param[1] = new SqlParameter("@C_idType", SqlDbType.VarChar, 50);
            param[1].Value = C_idType;
            param[2] = new SqlParameter("@C_Fname", SqlDbType.VarChar, 50);
            param[2].Value = C_Fname;
            param[3] = new SqlParameter("@C_Sname", SqlDbType.VarChar, 50);
            param[3].Value = C_Sname;
            param[4] = new SqlParameter("@C_Tname", SqlDbType.VarChar, 50);
            param[4].Value = C_Tname;
            param[5] = new SqlParameter("@C_Lname", SqlDbType.VarChar, 50);
            param[5].Value = C_Lname;
            param[6] = new SqlParameter("@C_Nationality", SqlDbType.VarChar, 50);
            param[6].Value = C_Nationality;
            param[7] = new SqlParameter("@C_Job", SqlDbType.VarChar, 50);
            param[7].Value = C_Job;

            param[8] = new SqlParameter("@C_WorkOrganization", SqlDbType.VarChar, 50);
            param[8].Value = C_WorkOrganization;
            param[9] = new SqlParameter("@C_Phone", SqlDbType.VarChar, 50);
            param[9].Value = C_Phone;
           

            DAL.Open();
            DAL.ExecuteCommand("ADD_CUSTOMERS", param);
            DAL.close();
        }

        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.close();
            return Dt;
        }

        public void DEIT_CUSTOMERS (string C_ID, string C_idType, string C_Fname, string C_Sname, string C_Tname, string C_Lname, string C_Nationality,
         string C_Job, string C_WorkOrganization, string C_Phone)
        {


            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@C_ID", SqlDbType.VarChar, 50);
            param[0].Value = C_ID;
            param[1] = new SqlParameter("@C_idType", SqlDbType.VarChar, 50);
            param[1].Value = C_idType;
            param[2] = new SqlParameter("@C_Fname", SqlDbType.VarChar, 50);
            param[2].Value = C_Fname;
            param[3] = new SqlParameter("@C_Sname", SqlDbType.VarChar, 50);
            param[3].Value = C_Sname;
            param[4] = new SqlParameter("@C_Tname", SqlDbType.VarChar, 50);
            param[4].Value = C_Tname;
            param[5] = new SqlParameter("@C_Lname", SqlDbType.VarChar, 50);
            param[5].Value = C_Lname;
            param[6] = new SqlParameter("@C_Nationality", SqlDbType.VarChar, 50);
            param[6].Value = C_Nationality;
            param[7] = new SqlParameter("@C_Job", SqlDbType.VarChar, 50);
            param[7].Value = C_Job;

            param[8] = new SqlParameter("@C_WorkOrganization", SqlDbType.VarChar, 50);
            param[8].Value = C_WorkOrganization;
            param[9] = new SqlParameter("@C_Phone", SqlDbType.VarChar, 50);
            param[9].Value = C_Phone;


            DAL.Open();
            DAL.ExecuteCommand("DEIT_CUSTOMERS", param);
            DAL.close();
        }

        public void DELETE_CUSTOMERS (string C_ID )
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@C_ID", SqlDbType.VarChar, 50);
            param[0].Value = C_ID;
            DAL.Open();
            DAL.ExecuteCommand("DELETE_CUSTOMERS", param);
            DAL.close();
        }
        public DataTable SEARCH_CUSTOMERS(string key)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param= new SqlParameter[1];
            param [0]= new SqlParameter("@key ", SqlDbType.VarChar, 50);
            param[0].Value = key;
            Dt = DAL.SelectData("SEARCH_CUSTOMERS", param);
            DAL.close();
            return Dt;




        }





    }
}
