using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDomain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
