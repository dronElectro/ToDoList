namespace ToDoList
{
    partial class NewTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecificationTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeadLinePicker = new System.Windows.Forms.DateTimePicker();
            this.PriorityNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.URLTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaskName";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(35, 32);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(195, 22);
            this.NameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Specification";
            // 
            // SpecificationTB
            // 
            this.SpecificationTB.Location = new System.Drawing.Point(35, 92);
            this.SpecificationTB.Multiline = true;
            this.SpecificationTB.Name = "SpecificationTB";
            this.SpecificationTB.Size = new System.Drawing.Size(195, 142);
            this.SpecificationTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do until:";
            // 
            // DeadLinePicker
            // 
            this.DeadLinePicker.Location = new System.Drawing.Point(35, 265);
            this.DeadLinePicker.Name = "DeadLinePicker";
            this.DeadLinePicker.Size = new System.Drawing.Size(195, 22);
            this.DeadLinePicker.TabIndex = 5;
            // 
            // PriorityNum
            // 
            this.PriorityNum.Location = new System.Drawing.Point(35, 318);
            this.PriorityNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriorityNum.Name = "PriorityNum";
            this.PriorityNum.Size = new System.Drawing.Size(195, 22);
            this.PriorityNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority";
            // 
            // URLTB
            // 
            this.URLTB.Location = new System.Drawing.Point(35, 377);
            this.URLTB.Name = "URLTB";
            this.URLTB.Size = new System.Drawing.Size(195, 22);
            this.URLTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Addition";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(49, 425);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(171, 57);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "Add Task";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 494);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.URLTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriorityNum);
            this.Controls.Add(this.DeadLinePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecificationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(287, 541);
            this.MinimumSize = new System.Drawing.Size(287, 541);
            this.Name = "NewTask";
            this.Text = "NewTask";
            ((System.ComponentModel.ISupportInitialize)(this.PriorityNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpecificationTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DeadLinePicker;
        private System.Windows.Forms.NumericUpDown PriorityNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox URLTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkButton;
    }
}