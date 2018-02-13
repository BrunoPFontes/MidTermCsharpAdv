using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListContextEF.Context;
using ToDoListDomain;
using ToDoListRepositoryStandard;

namespace ToDoListRepositoryEF
{
    public class ToDoListRepositoryCategoryEF : IRepository<Category>
    {
        public List<Category> SelectAll(){
            using (var context = new ToDoListContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category SelectById(int id)
        {
            using (var context = new ToDoListContext())
            {               
                return context.Categories.Find(id);
            }
        }

        public void Insert(Category entity)
        {
            using (var context = new ToDoListContext())
            {
                context.Categories.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Category entity)
        {
            using (var context = new ToDoListContext())
            {
                context.Categories.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (var context = new ToDoListContext())
            {
                context.Categories.Attach(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
