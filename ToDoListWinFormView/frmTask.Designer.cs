namespace ToDoListWinFormView
{
    partial class frmTask
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
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.IdTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(692, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(94, 23);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "&Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(692, 55);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateTask.TabIndex = 1;
            this.btnUpdateTask.Text = "&Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(692, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTask,
            this.IdCategory,
            this.NameTask,
            this.DateTask,
            this.CategoryTask,
            this.NotesTask});
            this.dgvTask.Location = new System.Drawing.Point(12, 12);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.Size = new System.Drawing.Size(662, 379);
            this.dgvTask.TabIndex = 3;
            // 
            // IdTask
            // 
            this.IdTask.DataPropertyName = "Id";
            this.IdTask.HeaderText = "Id";
            this.IdTask.Name = "IdTask";
            this.IdTask.ReadOnly = true;
            this.IdTask.Visible = false;
            // 
            // IdCategory
            // 
            this.IdCategory.DataPropertyName = "CategoryId";
            this.IdCategory.HeaderText = "IdCategory";
            this.IdCategory.Name = "IdCategory";
            this.IdCategory.ReadOnly = true;
            this.IdCategory.Visible = false;
            // 
            // NameTask
            // 
            this.NameTask.DataPropertyName = "Name";
            this.NameTask.HeaderText = "Name";
            this.NameTask.Name = "NameTask";
            this.NameTask.ReadOnly = true;
            this.NameTask.Width = 150;
            // 
            // DateTask
            // 
            this.DateTask.DataPropertyName = "DateTime";
            this.DateTask.HeaderText = "Date";
            this.DateTask.Name = "DateTask";
            this.DateTask.ReadOnly = true;
            // 
            // CategoryTask
            // 
            this.CategoryTask.DataPropertyName = "Category";
            this.CategoryTask.HeaderText = "Category";
            this.CategoryTask.Name = "CategoryTask";
            this.CategoryTask.ReadOnly = true;
            this.CategoryTask.Width = 150;
            // 
            // NotesTask
            // 
            this.NotesTask.DataPropertyName = "Notes";
            this.NotesTask.HeaderText = "Notes";
            this.NotesTask.Name = "NotesTask";
            this.NotesTask.ReadOnly = true;
            this.NotesTask.Width = 218;
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnAddTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTask";
            this.Text = "Tasks To Do";
            this.Load += new System.EventHandler(this.frmTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesTask;
    }
}