using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class MySQLConnectionString :IConnectionString
    {
        String _server;
        String _user;
        String _pass;
        String _port;
        String _dataBase;


        public MySQLConnectionString(String Server, String User, String Password, String DBName, String Port)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = Port;
            _dataBase = DBName;
        }

        public MySQLConnectionString(String Server, String User, String Password, String DBName)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = "3306";
            _dataBase = DBName;
        }
        public string ConnectionString()
        {
            String connStr = "Server=" + _server + ";" +
                    "Database=" + _dataBase + ";" +
                    "Uid=" + _user + ";" +
                    "Pwd=" + _pass + ";" +
                    "Port =" + _port + ";";
            return connStr;

        }
    }
}
