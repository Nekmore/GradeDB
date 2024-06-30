namespace GradeDB.Forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnGenerateXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateXML
            // 
            this.btnGenerateXML.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateXML.Name = "btnGenerateXML";
            this.btnGenerateXML.Size = new System.Drawing.Size(120, 30);
            this.btnGenerateXML.TabIndex = 0;
            this.btnGenerateXML.Text = "Generate XML";
            this.btnGenerateXML.UseVisualStyleBackColor = true;
            this.btnGenerateXML.Click += new System.EventHandler(this.btnGenerateXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnGenerateXML;
    }
}
