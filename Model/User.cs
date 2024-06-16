namespace ChattingApp.Model
{
    public class User
    {
        public String name, email, password;
        public int portNumber;

        public User(String name, String email, String password, int portNumber)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.portNumber = portNumber;
        }
    }
}