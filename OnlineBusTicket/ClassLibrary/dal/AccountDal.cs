﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary.dal
{
    public class AccountDal: ApCoreDBConnect
    {
        /*
         * @todo: login 
         * */
        public static object Login(String username, String password)
        {
            SqlParameter[] arrParameter = new SqlParameter[2];

            arrParameter[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            arrParameter[0].Value = username;

            arrParameter[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            arrParameter[1].Value = password;

            return ExcuteScalar("sp_Login", arrParameter);
        }
        /*
         * @todo: get acc by username
         * */
        public static object GetAccountIdByUsername(string username)
        {
            SqlParameter[] arrParameter = new SqlParameter[1];

            arrParameter[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
            arrParameter[0].Value = username;

            return ExcuteScalar("sp_GetAccountIdByUsername", arrParameter);
        }
    }
}