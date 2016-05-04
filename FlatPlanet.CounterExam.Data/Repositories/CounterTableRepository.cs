using FlatPlanet.CounterExam.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.CounterExam.Data.Repositories
{
    public class CounterTableRepository : BaseRepository, ICounterTableRepository
    {
        public void Increment(out string message , out bool isError )
        { 
            message = "";
            isError = false;

            #region data access

            using (var con = new SqlConnection(this.ConnectionStr))
            {
                using (var cmd = new SqlCommand("Increm", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // parameters
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Message", SqlDbType = SqlDbType.NVarChar, DbType = DbType.String, Size = 1000, Direction = ParameterDirection.InputOutput }).Value = message;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsError", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.InputOutput }).Value = isError;

                    con.Open();

                    // execute
                    cmd.ExecuteNonQuery();

                    // out params
                    message = cmd.Parameters["@Message"].Value.ToString();
                    isError = Convert.ToBoolean(cmd.Parameters["@IsError"].Value);
                }
            }

            #endregion
        }

        public void Reset(out string message, out bool isError)
        {
            message = "";
            isError = false;

            #region data access

            using (var con = new SqlConnection(this.ConnectionStr))
            {
                using (var cmd = new SqlCommand("Reset", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // parameters
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Message", SqlDbType = SqlDbType.NVarChar, DbType = DbType.String, Size = 1000, Direction = ParameterDirection.InputOutput }).Value = message;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsError", SqlDbType = SqlDbType.Bit,   Direction = ParameterDirection.InputOutput }).Value = isError;

                    con.Open();

                    // execute
                    cmd.ExecuteNonQuery();

                    // out params
                    message = cmd.Parameters["@Message"].Value.ToString();
                    isError = Convert.ToBoolean(cmd.Parameters["@IsError"].Value);
                }
            }

            #endregion
        }

        public int Get( out string message, out bool isError)
        {
            message = "";
            isError = false;
            var counterfield = 1;

            #region data access 

            using (var con = new SqlConnection(this.ConnectionStr))
            {
                using (var cmd = new SqlCommand("Get", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // parameters
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Message", SqlDbType = SqlDbType.NVarChar, DbType = DbType.String, Size = 1000, Direction = ParameterDirection.InputOutput }).Value = message;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@IsError", SqlDbType = SqlDbType.Bit,   Direction = ParameterDirection.InputOutput }).Value = isError;

                    con.Open();

                    // execute
                    counterfield = Convert.ToInt32(cmd.ExecuteScalar()) ;

                    // out params
                    message = cmd.Parameters["@Message"].Value.ToString();
                    isError = Convert.ToBoolean(cmd.Parameters["@IsError"].Value );
                }
            }

            #endregion 

            return counterfield;
        }
    }
}
