﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ToDoList
{
    class SELECT
    {
        MySQLDBConnection _connection;
        public DataTable Table { get; private set; }
        public SELECT(MySQLDBConnection connection)
        {
            _connection = connection;
            Table = new DataTable();
        }

        public void Select(string tableName, string options="1")
        {
            string query = "SELECT * FROM " + tableName + " WHERE " + options;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, _connection.Connection);
            Table.Clear();
            dataAdapter.Fill(Table);
        }
        public List<string> TableToList(int index)
        {
            if(index < Table.Rows.Count)
            {
                List<string> result = new List<string>();
                DataRow row = Table.Rows[index];

                int len = row.ItemArray.Length;
                for (int i = 0; i < len; i++)
                    result.Add(row.ItemArray[i].ToString());
                return result;
            }
            return null;
        }
    }
}
