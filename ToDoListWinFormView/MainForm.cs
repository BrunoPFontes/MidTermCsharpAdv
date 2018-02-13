using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListWinFormView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var categoryForm = new frmCategory();
            categoryForm.Show();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            var taskForm = new frmTask();
            taskForm.Show();
        }
    }
}
