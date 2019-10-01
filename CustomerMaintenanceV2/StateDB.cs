using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceV2
{
    public class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement = "SELECT StateCode, StateName "
                                   + "FROM States "
                                   + "ORDER BY StateName";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    State state = new State();
                    state.StateCode = reader["StateCode"].ToString();
                    state.StateName = reader["StateName"].ToString();

                    states.Add(state);
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return states;
        }
    }
}
