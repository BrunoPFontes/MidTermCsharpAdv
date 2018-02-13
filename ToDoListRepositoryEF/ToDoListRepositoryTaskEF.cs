using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ToDoListContextEF.Context;
using ToDoListDomain;
using ToDoListRepositoryStandard;

namespace ToDoListRepositoryEF
{
    public class ToDoListRepositoryTaskEF : IRepository<Task>
    {
        public List<Task> SelectAll()
        {
            using (var context = new ToDoListContext())
            {
                return context.Tasks.Include("Category").ToList();
            }
        }

        public Task SelectById(int id)
        {
            using (var context = new ToDoListContext())
            {
                return context.Tasks.Include("Category").Single(t => t.Id == id);
            }
        }

        public void Insert(Task entity)
        {
            using (var context = new ToDoListContext())
            {
                Category category = context.Categories.Find(entity.CategoryId);
                entity.Category = category;
                context.Tasks.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Task entity)
        {
            using (var context = new ToDoListContext() )
            {
                Category category = context.Categories.Find(entity.CategoryId);
                entity.Category = category;
                context.Tasks.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Delete(Task entity)
        {
            using (var context = new ToDoListContext())
            {
                context.Tasks.Attach(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
