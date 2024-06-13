namespace GradeDB.Forms
{
    partial class Query
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

        private void InitializeComponent()
        {
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnGetStudents = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.lblRecordBook = new System.Windows.Forms.Label();
            this.txtRecordBook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(12, 12);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(150, 23);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Тест подключения";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnGetStudents
            // 
            this.btnGetStudents.Location = new System.Drawing.Point(12, 41);
            this.btnGetStudents.Name = "btnGetStudents";
            this.btnGetStudents.Size = new System.Drawing.Size(150, 23);
            this.btnGetStudents.TabIndex = 1;
            this.btnGetStudents.Text = "Список студентов";
            this.btnGetStudents.UseVisualStyleBackColor = true;
            this.btnGetStudents.Click += new System.EventHandler(this.btnGetStudents_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 186);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(150, 23);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(121, 70);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(200, 20);
            this.txtFIO.TabIndex = 3;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(121, 96);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 4;
            this.dateTimePickerDOB.Value = new System.DateTime(2023, 1, 4, 0, 0, 0, 0);
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(121, 122);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(200, 20);
            this.txtGroupID.TabIndex = 5;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 215);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(309, 160);
            this.listBoxStudents.TabIndex = 6;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 73);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 7;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(12, 99);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(89, 13);
            this.labelDOB.TabIndex = 8;
            this.labelDOB.Text = "Дата рождения:";
            // 
            // labelGroupID
            // 
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Location = new System.Drawing.Point(12, 125);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(60, 13);
            this.labelGroupID.TabIndex = 9;
            this.labelGroupID.Text = "ID группы:";
            // 
            // lblRecordBook
            // 
            this.lblRecordBook.AutoSize = true;
            this.lblRecordBook.Location = new System.Drawing.Point(12, 151);
            this.lblRecordBook.Name = "lblRecordBook";
            this.lblRecordBook.Size = new System.Drawing.Size(98, 13);
            this.lblRecordBook.TabIndex = 10;
            this.lblRecordBook.Text = "Зачетная книжка:";
            // 
            // txtRecordBook
            // 
            this.txtRecordBook.Location = new System.Drawing.Point(121, 148);
            this.txtRecordBook.Name = "txtRecordBook";
            this.txtRecordBook.Size = new System.Drawing.Size(200, 20);
            this.txtRecordBook.TabIndex = 11;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 400);
            this.Controls.Add(this.txtRecordBook);
            this.Controls.Add(this.lblRecordBook);
            this.Controls.Add(this.labelGroupID);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnGetStudents);
            this.Controls.Add(this.btnTestConnection);
            this.Name = "Query";
            this.Text = "Запрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnGetStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGroupID;
        private System.Windows.Forms.Label lblRecordBook;
        private System.Windows.Forms.TextBox txtRecordBook;
    }
}
