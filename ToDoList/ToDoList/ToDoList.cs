using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList: ITable
    {
        public string Id { get; private set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string DeadLine { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Url { get; set; }
        static public string TableName = "todolist";
        public List<string> ColumnNames;

        public List<string> GetColumnNames()
        {
            return ColumnNames;
        }

        public string GetTableName()
        {
            return TableName;
        }

        public List<string> GetData()
        {
            List<string> userData = new List<string>();
            if (Id == null)
                Id = "NULL";
            userData.Add(Id);
            userData.Add(UserID);
            userData.Add(Name);
            userData.Add(Note);
            userData.Add(DeadLine);
            userData.Add(Status);
            userData.Add(Priority);
            userData.Add(Url);
            return userData;
        }

        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("userID");
            ColumnNames.Add("name");
            ColumnNames.Add("note");
            ColumnNames.Add("deadline");
            ColumnNames.Add("status");
            ColumnNames.Add("priority");
            ColumnNames.Add("url");
        }
        public ToDoList(string userID, string name, string note, string deadLine, string status, string priority, string url)
        {
            UserID = userID;
            Name = name;
            Note = note;
            DeadLine = deadLine;
            Status = status;
            Priority = priority;
            Url = url;
            SetColumnNames();
        }

        public ToDoList(List<string> ToDoListData)
        {
            GetDataFromList(ToDoListData);
            SetColumnNames();
        }
        public void GetDataFromList(List<string> ToDoListData)
        {
            Id = ToDoListData[0];
            UserID = ToDoListData[1];
            Name = ToDoListData[2];
            Note = ToDoListData[3];
            DeadLine = ToDoListData[4];
            Status = ToDoListData[5];
            Priority = ToDoListData[6];
            Url = ToDoListData[7];
        }
    }
}
