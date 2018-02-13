using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListDomain;
using Task = ToDoListDomain.Task;

namespace ToDoListContextEF.Context
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public ToDoListContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasRequired(c => c.Category)
                .WithMany(t => t.Tasks)
                .HasForeignKey(fk => fk.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }

}

