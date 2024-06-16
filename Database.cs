﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    public class SQLDatabase
    {
        private static SQLDatabase? _SQLDatabase = null;
        private SqlConnection? _sqlConnection = null;
        private String connString = "Data Source = DESKTOP-VU7KF0Q;Initial Catalog = ChattingApp;Integrated Security = true";
        public SqlConnection getSqlConnection() => _sqlConnection;
        private SQLDatabase()
        {
            _sqlConnection = new SqlConnection(connString);
            _sqlConnection.OpenAsync();
        }

        public static SQLDatabase getInstance()
        {
            if (_SQLDatabase == null)
            {
                _SQLDatabase = new SQLDatabase();
            }

            return _SQLDatabase;
        }

        public async Task<SqlDataReader> read(SqlCommand command)
        {
                SqlDataReader reader = await command.ExecuteReaderAsync();
                return reader;  
        }
  
        public async Task<bool> insert(SqlCommand command)
        {
            int rowsAffected = await command.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }
        public async Task<bool> update(SqlCommand command)
        {
            int rowsAffected = await command.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }
        public async Task<bool> delete(SqlCommand command)
        {
            int rowsAffected = await command.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }


        ~SQLDatabase()
        {
            _sqlConnection.Close();
        }
    }
}
