namespace GradeDB.Forms
{
    partial class Parameter
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
            this.btnGetPlan = new System.Windows.Forms.Button();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.listBoxPlan = new System.Windows.Forms.ListBox();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetPlan
            // 
            this.btnGetPlan.Location = new System.Drawing.Point(12, 38);
            this.btnGetPlan.Name = "btnGetPlan";
            this.btnGetPlan.Size = new System.Drawing.Size(150, 23);
            this.btnGetPlan.TabIndex = 1;
            this.btnGetPlan.Text = "Получить план сессии";
            this.btnGetPlan.UseVisualStyleBackColor = true;
            this.btnGetPlan.Click += new System.EventHandler(this.btnGetPlan_Click);
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(103, 12);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(182, 20);
            this.txtGroupID.TabIndex = 3;
            // 
            // listBoxPlan
            // 
            this.listBoxPlan.FormattingEnabled = true;
            this.listBoxPlan.Location = new System.Drawing.Point(12, 67);
            this.listBoxPlan.Name = "listBoxPlan";
            this.listBoxPlan.Size = new System.Drawing.Size(574, 238);
            this.listBoxPlan.TabIndex = 6;
            // 
            // labelGroupID
            // 
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Location = new System.Drawing.Point(12, 15);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(60, 13);
            this.labelGroupID.TabIndex = 9;
            this.labelGroupID.Text = "ID группы:";
            // 
            // Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 328);
            this.Controls.Add(this.labelGroupID);
            this.Controls.Add(this.listBoxPlan);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.btnGetPlan);
            this.Name = "Parameter";
            this.Text = "Параметры запроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnGetPlan;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.ListBox listBoxPlan;
        private System.Windows.Forms.Label labelGroupID;
    }
}