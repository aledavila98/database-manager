using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    class ConnectionManager
    {
        public static String usuario;
        public static String password;
        public static String localhost;

        public ConnectionManager(String u, String p)
        {
            usuario = u;
            password = p;
            localhost = "localhost";
        }

    }
}
