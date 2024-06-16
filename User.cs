using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    internal class User
    {
        public String name, email, password;
        public int portNumber;
        public User(String name,String email,String password,int portNumber)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.portNumber = portNumber;
        }
    }
}
