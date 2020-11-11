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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 52);
            this.panel1.TabIndex = 0;
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(13, 13);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(75, 23);
            this.NewTaskButton.TabIndex = 0;
            this.NewTaskButton.Text = "button1";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // MyTasksDG
            // 
            this.MyTasksDG.AllowUserToAddRows = false;
            this.MyTasksDG.AllowUserToDeleteRows = false;
            this.MyTasksDG.AllowUserToResizeRows = false;
            this.MyTasksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTasksDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTasksDG.Location = new System.Drawing.Point(0, 52);
            this.MyTasksDG.MultiSelect = false;
            this.MyTasksDG.Name = "MyTasksDG";
            this.MyTasksDG.ReadOnly = true;
            this.MyTasksDG.RowHeadersVisible = false;
            this.MyTasksDG.RowHeadersWidth = 51;
            this.MyTasksDG.RowTemplate.Height = 24;
            this.MyTasksDG.Size = new System.Drawing.Size(509, 445);
            this.MyTasksDG.TabIndex = 1;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 497);
            this.Controls.Add(this.MyTasksDG);
            this.Controls.Add(this.panel1);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDo_FormClosed);
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.DataGridView MyTasksDG;
    }
}