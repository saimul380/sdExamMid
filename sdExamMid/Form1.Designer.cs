namespace sdExamMid
{
    partial class Form1
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
            this.lb_matricId = new System.Windows.Forms.Label();
            this.lb_studentName = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.textBox_MatricID = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.textBox_department = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_matricId
            // 
            this.lb_matricId.AutoSize = true;
            this.lb_matricId.Location = new System.Drawing.Point(184, 53);
            this.lb_matricId.Name = "lb_matricId";
            this.lb_matricId.Size = new System.Drawing.Size(50, 13);
            this.lb_matricId.TabIndex = 0;
            this.lb_matricId.Text = "Matric ID";
            // 
            // lb_studentName
            // 
            this.lb_studentName.AutoSize = true;
            this.lb_studentName.Location = new System.Drawing.Point(184, 81);
            this.lb_studentName.Name = "lb_studentName";
            this.lb_studentName.Size = new System.Drawing.Size(75, 13);
            this.lb_studentName.TabIndex = 0;
            this.lb_studentName.Text = "Student Name";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.Location = new System.Drawing.Point(184, 115);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(62, 13);
            this.lb_department.TabIndex = 0;
            this.lb_department.Text = "Department";
            // 
            // textBox_MatricID
            // 
            this.textBox_MatricID.Location = new System.Drawing.Point(265, 50);
            this.textBox_MatricID.Name = "textBox_MatricID";
            this.textBox_MatricID.Size = new System.Drawing.Size(156, 20);
            this.textBox_MatricID.TabIndex = 0;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Location = new System.Drawing.Point(265, 79);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(156, 20);
            this.textBox_StudentName.TabIndex = 1;
            // 
            // textBox_department
            // 
            this.textBox_department.Location = new System.Drawing.Point(265, 112);
            this.textBox_department.Name = "textBox_department";
            this.textBox_department.Size = new System.Drawing.Size(156, 20);
            this.textBox_department.TabIndex = 2;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(203, 182);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(334, 182);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(75, 23);
            this.button_Show.TabIndex = 2;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 102);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_department);
            this.Controls.Add(this.textBox_StudentName);
            this.Controls.Add(this.textBox_MatricID);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.lb_studentName);
            this.Controls.Add(this.lb_matricId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_matricId;
        private System.Windows.Forms.Label lb_studentName;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.TextBox textBox_MatricID;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.TextBox textBox_department;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

