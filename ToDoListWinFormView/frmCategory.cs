using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListDomain;
using ToDoListRepositoryEF;
using ToDoListRepositoryStandard;
using ToDoListWinFormView.ViewModels;

namespace ToDoListWinFormView
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadDgvCaterogies();
        }

        private void LoadDgvCaterogies()
        {
            IRepository<Category> repositoryCategory = new ToDoListRepositoryCategoryEF();
            var categories = repositoryCategory.SelectAll();

            var categoriesViewModel = categories.Select(category => new CategoryViewModel
                {
                    Id = category.Id,
                    Name = category.Name
                })
                .ToList();
            dgvCategories.DataSource = categoriesViewModel;
            dgvCategories.Refresh();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddEditCategory addEditCategory = new frmAddEditCategory();
            addEditCategory.ShowDialog();
            LoadDgvCaterogies();
        }
    }
}
