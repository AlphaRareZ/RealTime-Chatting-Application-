using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    internal class ProxyDatabase
    {
        SQLDatabase myDB = null;
        public ProxyDatabase()
        {
            myDB = SQLDatabase.getInstance();
        }
        public async Task<Boolean> insertAsync(String sender,String recieverPortNum,String message)
        {
            SqlCommand command = new SqlCommand("insert into history values(@s,@r,@m,CURRENT_TIMESTAMP)",myDB.getSqlConnection());
            command.Parameters.AddWithValue("@s", sender);
            command.Parameters.AddWithValue("@r", recieverPortNum);
            command.Parameters.AddWithValue("@m", message);
            bool inserted = await myDB.insert(command);
            return inserted;
        }
    }
}
