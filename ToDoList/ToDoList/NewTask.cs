using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }
        string Uid;
        public NewTask(string UserId)
        {
            Uid = UserId;
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ToDoList newTask = new ToDoList(Uid, NameTB.Text,
                SpecificationTB.Text, DeadLinePicker.Value.ToString("yyyy-MM-dd"), "не начато",
                PriorityNum.Value.ToString(), URLTB.Text);
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "testDB");
            MySQLDBConnection mySQLDB = new MySQLDBConnection(connStr);

            INSERT insertTask = new INSERT(mySQLDB);
            insertTask.Insert(newTask);

        }
    }
}
