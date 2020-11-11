using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }
        string userId;
        string query;
        string url;
        string id;
        public ToDo(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }
        MySQLDBConnection mySQLDB;
        private void refreshDataGrid(string query)
        {
            SELECT select = new SELECT(mySQLDB);
            select.Select(query);
            MyTasksDG.DataSource = select.Table;
        }

        private void ToDo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask(userId);
            newTask.ShowDialog();
            refreshDataGrid($"SELECT id, name, priority, status, deadline from todolist where userId = {userId}");
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            query = $"SELECT id, name, priority, status, deadline from todolist where userId = {userId}";
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "testDB");
            mySQLDB = new MySQLDBConnection(connStr);
            refreshDataGrid($"SELECT id, name, priority, status, deadline from todolist where userId = {userId}");
        }

        private void MyTasksDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                id = MyTasksDG[0, index].Value.ToString();
                SELECT select = new SELECT(mySQLDB);
                select.Select("SELECT note, status,url FROM todolist WHERE id =" + id);
                NoteRTB.Text = select.Table.Rows[0].ItemArray[0].ToString();
                StatusCB.Text = select.Table.Rows[0].ItemArray[1].ToString();
                url = select.Table.Rows[0].ItemArray[2].ToString();
            }
            

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if(folderBrowser.ShowDialog()==DialogResult.OK)
            {
                Downloader download = new Downloader(url, folderBrowser.SelectedPath);
                if(download.downloadFile())
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Warning");
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UPDATEToDoList update = new UPDATEToDoList(mySQLDB);
            update.Update(id, NoteRTB.Text, StatusCB.Text);
        }
    }
}
