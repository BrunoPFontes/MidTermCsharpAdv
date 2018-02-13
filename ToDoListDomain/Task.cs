using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListDomain
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime DateTime { get; set; }
    }
}
