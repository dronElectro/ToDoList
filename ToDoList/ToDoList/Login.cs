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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySQLConnectionString connStr;
        MySQLDBConnection mySQLDB;
        SELECT select;
        User newUser;


        private void Login_Load(object sender, EventArgs e)
        {
            connStr = new MySQLConnectionString("localhost", "root", "root", "testDB");
            mySQLDB = new MySQLDBConnection(connStr);
            select = new SELECT(mySQLDB);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            select.Select(User.TableName, "user = '" + TBName.Text + "' and pass ='" + TBPass.Text + "'");
            if(select.TableToList(0)!=null)
            {
                User loginUser = new User(select.TableToList(0));
                ToDo toDo = new ToDo(loginUser.Id);
                toDo.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
            }

        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if((TBName.Text != "" || TBName.Text !=null) && (TBPass.Text != "" || TBPass.Text != null))
            {
                newUser = new User(TBName.Text, TBPass.Text, now.ToString("yyyy-MM-dd HH:mm:ss"));
                INSERT insert = new INSERT(mySQLDB);
                insert.Insert(newUser);
            }
        }
    }
}




















