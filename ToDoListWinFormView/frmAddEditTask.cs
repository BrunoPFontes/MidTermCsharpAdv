using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoListDomain;
using ToDoListRepositoryEF;
using ToDoListRepositoryStandard;
using ToDoListWinFormView.ViewModels;

namespace ToDoListWinFormView
{
    public partial class frmAddEditTask : Form
    {
        public frmAddEditTask()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditTask_Load(object sender, EventArgs e)
        {
            IRepository<Task> taskRepository = new ToDoListRepositoryTaskEF();
            List<Task> tasks = taskRepository.SelectAll();

            List<TaskViewModels> tasksViewModels = new List<TaskViewModels>();

            foreach (var task in tasks)
            {
                var taskViewModel = new TaskViewModels()
                {
                    Id = task.Id,
                    Name = task.Name,
                    DateTime = task.DateTime,
                    CategoryId = task.CategoryId,
                    Category = task.Category.Name,
                    Notes = task.Notes
                };
                tasksViewModels.Add(taskViewModel);

            }
            cmbCategory.DataSource = tasksViewModels;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.Refresh();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Task task = new Task
            {
                Name = txtName.Text,
                DateTime = mcDate.SelectionStart,
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                Notes = txtNotes.Text
            };

            IRepository<Task> taskRepository = new ToDoListRepositoryTaskEF();
            taskRepository.Insert(task);
            Close();

        }
    }
}
