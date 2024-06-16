using System.Data.SqlClient;
using ChattingApp.Model;

namespace ChattingApp.Database
{
    public class ProxyDatabase
    {
        SQLDatabase myDB = null;
        private static ProxyDatabase proxyDatabase = null;
        private ProxyDatabase()
        {
            myDB = SQLDatabase.getInstance();
        }
        public static ProxyDatabase getInstance()
        {
            if (proxyDatabase == null) proxyDatabase = new ProxyDatabase();
            return proxyDatabase;
        }
        public async Task<Boolean> insertHistoryAsync(String sender,String recieverPortNum,String message)
        {
            SqlCommand command = new SqlCommand("insert into history values(@Sender,@Reciever,@Message,CURRENT_TIMESTAMP)",myDB.getSqlConnection());
            command.Parameters.AddWithValue("@Sender", sender);
            command.Parameters.AddWithValue("@Reciever", recieverPortNum);
            command.Parameters.AddWithValue("@Message", message);
            bool inserted = await myDB.insert(command);
            return inserted;
        }public async Task<Boolean> insertUserAsync(String name,String email,String password)
        {
            SqlCommand command = new SqlCommand("insert into users values(@name,@email,@password)",myDB.getSqlConnection());
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@name", name);
            bool inserted = await myDB.insert(command);
            return inserted;
        }
        public async Task<bool> userExists(String email,String password)
        {
            SqlCommand command = new SqlCommand("SELECT portNum from users where email = @email and password = @password",myDB.getSqlConnection());
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = await myDB.read(command);
            bool hasRows = reader.HasRows;
            reader.Close();
            return hasRows;
        }public async Task<User> UserExistsSignIn(String email,String password)
        {
            SqlCommand command = new SqlCommand("SELECT * from users where email = @email and password = @password",myDB.getSqlConnection());
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = await myDB.read(command);
            if (reader.HasRows){
                reader.Read();
                User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                reader.Close();
                return user;
            }
            reader.Close();
            return null;
        }

    }
}
