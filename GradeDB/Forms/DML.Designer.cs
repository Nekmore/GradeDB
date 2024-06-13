namespace GradeDB.Forms
{
    partial class DML
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
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnUpdateMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtSemesterID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSubjectID = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelSemesterID = new System.Windows.Forms.Label();
            this.labelMarkID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtMarkID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMark
            // 
            this.btnAddMark.Location = new System.Drawing.Point(15, 158);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(120, 23);
            this.btnAddMark.TabIndex = 0;
            this.btnAddMark.Text = "Добавить оценку";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnUpdateMark
            // 
            this.btnUpdateMark.Location = new System.Drawing.Point(15, 187);
            this.btnUpdateMark.Name = "btnUpdateMark";
            this.btnUpdateMark.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateMark.TabIndex = 1;
            this.btnUpdateMark.Text = "Изменить оценку";
            this.btnUpdateMark.UseVisualStyleBackColor = true;
            this.btnUpdateMark.Click += new System.EventHandler(this.btnUpdateMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Location = new System.Drawing.Point(15, 216);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteMark.TabIndex = 2;
            this.btnDeleteMark.Text = "Удалить оценку";
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(122, 12);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(150, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(122, 38);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(150, 20);
            this.txtSubjectID.TabIndex = 4;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(122, 64);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(150, 20);
            this.txtMark.TabIndex = 5;
            // 
            // txtSemesterID
            // 
            this.txtSemesterID.Location = new System.Drawing.Point(122, 90);
            this.txtSemesterID.Name = "txtSemesterID";
            this.txtSemesterID.Size = new System.Drawing.Size(150, 20);
            this.txtSemesterID.TabIndex = 6;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(12, 15);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(69, 13);
            this.labelStudentID.TabIndex = 12;
            this.labelStudentID.Text = "ID студента:";
            // 
            // labelSubjectID
            // 
            this.labelSubjectID.AutoSize = true;
            this.labelSubjectID.Location = new System.Drawing.Point(12, 41);
            this.labelSubjectID.Name = "labelSubjectID";
            this.labelSubjectID.Size = new System.Drawing.Size(73, 13);
            this.labelSubjectID.TabIndex = 13;
            this.labelSubjectID.Text = "ID предмета:";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(12, 67);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(48, 13);
            this.labelMark.TabIndex = 14;
            this.labelMark.Text = "Оценка:";
            // 
            // labelSemesterID
            // 
            this.labelSemesterID.AutoSize = true;
            this.labelSemesterID.Location = new System.Drawing.Point(12, 93);
            this.labelSemesterID.Name = "labelSemesterID";
            this.labelSemesterID.Size = new System.Drawing.Size(73, 13);
            this.labelSemesterID.TabIndex = 15;
            this.labelSemesterID.Text = "ID семестра:";
            // 
            // labelMarkID
            // 
            this.labelMarkID.AutoSize = true;
            this.labelMarkID.Location = new System.Drawing.Point(12, 118);
            this.labelMarkID.Name = "labelMarkID";
            this.labelMarkID.Size = new System.Drawing.Size(60, 13);
            this.labelMarkID.TabIndex = 16;
            this.labelMarkID.Text = "ID оценки:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 216);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(15, 245);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Обновить список";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtMarkID
            // 
            this.txtMarkID.Location = new System.Drawing.Point(122, 118);
            this.txtMarkID.Name = "txtMarkID";
            this.txtMarkID.Size = new System.Drawing.Size(150, 20);
            this.txtMarkID.TabIndex = 19;
            // 
            // DML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 282);
            this.Controls.Add(this.txtMarkID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelMarkID);
            this.Controls.Add(this.labelSemesterID);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelSubjectID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.txtSemesterID);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnUpdateMark);
            this.Controls.Add(this.btnAddMark);
            this.Name = "DML";
            this.Text = "Управление оценками";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnUpdateMark;
        private System.Windows.Forms.Button btnDeleteMark;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtSemesterID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSubjectID;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelSemesterID;
        private System.Windows.Forms.Label labelMarkID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtMarkID;
    }
}
