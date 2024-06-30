namespace UniversityApp
{
    partial class SyncDatabase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинный, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(100, 100);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(150, 50);
            this.buttonSync.TabIndex = 0;
            this.buttonSync.Text = "Синхронизировать";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // SyncDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonSync);
            this.Name = "SyncDatabase";
            this.Text = "University App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSync;
    }
}
