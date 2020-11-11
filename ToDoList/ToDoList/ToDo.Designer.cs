namespace ToDoList
{
    partial class ToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.MyTasksDG = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.NoteRTB = new System.Windows.Forms.RichTextBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 31);
            this.panel1.TabIndex = 0;
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(3, 5);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(83, 23);
            this.NewTaskButton.TabIndex = 0;
            this.NewTaskButton.Text = "New Task";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // MyTasksDG
            // 
            this.MyTasksDG.AllowUserToAddRows = false;
            this.MyTasksDG.AllowUserToDeleteRows = false;
            this.MyTasksDG.AllowUserToResizeRows = false;
            this.MyTasksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTasksDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyTasksDG.Location = new System.Drawing.Point(0, 31);
            this.MyTasksDG.MultiSelect = false;
            this.MyTasksDG.Name = "MyTasksDG";
            this.MyTasksDG.ReadOnly = true;
            this.MyTasksDG.RowHeadersVisible = false;
            this.MyTasksDG.RowHeadersWidth = 51;
            this.MyTasksDG.RowTemplate.Height = 24;
            this.MyTasksDG.Size = new System.Drawing.Size(690, 480);
            this.MyTasksDG.TabIndex = 1;
            this.MyTasksDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyTasksDG_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.DownloadBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StatusCB);
            this.panel2.Controls.Add(this.NoteRTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(690, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 480);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
            // 
            // StatusCB
            // 
            this.StatusCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Items.AddRange(new object[] {
            "In progress",
            "Done",
            "Not started",
            "Not needed"});
            this.StatusCB.Location = new System.Drawing.Point(0, 96);
            this.StatusCB.Margin = new System.Windows.Forms.Padding(1);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(168, 24);
            this.StatusCB.TabIndex = 1;
            // 
            // NoteRTB
            // 
            this.NoteRTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteRTB.Location = new System.Drawing.Point(0, 0);
            this.NoteRTB.Name = "NoteRTB";
            this.NoteRTB.Size = new System.Drawing.Size(168, 96);
            this.NoteRTB.TabIndex = 0;
            this.NoteRTB.Text = "";
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DownloadBtn.Location = new System.Drawing.Point(0, 137);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(1);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(168, 23);
            this.DownloadBtn.TabIndex = 3;
            this.DownloadBtn.Text = "Additionally";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveBtn.Location = new System.Drawing.Point(0, 160);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(168, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MyTasksDG);
            this.Controls.Add(this.panel1);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDo_FormClosed);
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.DataGridView MyTasksDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.RichTextBox NoteRTB;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}