using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HMLalpha.Models
{
    internal class DataConfigurations
    {
        // Database connection configurator
        public static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseAccess"].ConnectionString;
     
        // Method for returning a single value.
        public static object ExecuteScalar(string query, CommandType type, params SqlParameter[] array)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open(); 
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(array);
            command.CommandType = type;
            return command.ExecuteScalar();
        }
        // Method for returning the number of rows affected after a transaction.
        public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] array)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(array);
            command.CommandType = type;
            return command.ExecuteNonQuery();
        }

        // Method for returning an affected table.
        public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] array)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(array);
            command.CommandType = type;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        // Method for creating a new parameter.
        public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = name;
            parameter.SqlDbType = type;
            parameter.SqlValue = value;   
            return parameter;
        }
    }
}
