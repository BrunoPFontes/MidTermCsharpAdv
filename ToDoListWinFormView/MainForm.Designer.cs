namespace ToDoListWinFormView
{
    partial class MainForm
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(83, 78);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(130, 121);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(276, 78);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(130, 121);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 300);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnTask;
    }
}

