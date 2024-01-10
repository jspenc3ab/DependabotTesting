using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependabotTesting
{
    public class SqlDatabase
    {
        #region Fields and Properties
        private readonly String _connectionString;
        //private readonly ILogger<SqlDatabase> _logger;
        #endregion

        #region Methods
        #region Constructors
        
        #endregion
        public void ExecuteSql(String sql, String name)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);  //TODO: Refactor this so the connection and reader can be inside a using statement.
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //return new SqlRecordSet(sqlDataReader);
            }
            catch (Exception ex)
            {
                if (connection != null)
                { connection.Close(); }

                throw new Exception($"Error executing SQL: '{sql}'.", ex);
            }
        }
        #endregion
    }
}