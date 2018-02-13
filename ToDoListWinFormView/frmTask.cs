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
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks()
        {
            IRepository<Task> taskRepository = new ToDoListRepositoryTaskEF();
            List<Task> tasks = taskRepository.SelectAll();
            List<TaskViewModels> taskViewModels = new List<TaskViewModels>();

            foreach (var task in tasks)
            { 

                TaskViewModels taskViewModel = new TaskViewModels
                {
                    Id = task.Id,
                    Name = task.Name,
                    DateTime = task.DateTime,
                    CategoryId = task.CategoryId,
                    Notes = task.Notes,
                    Category = task.Category.Name
                };
                taskViewModels.Add(taskViewModel);

                dgvTask.DataSource = taskViewModels;
                dgvTask.Refresh();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task task = new Task
            {
                Name = 
            };
        }
    }
}
