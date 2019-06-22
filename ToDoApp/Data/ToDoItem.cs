using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class ToDo
    {
        public int Id { get; set; }
        public string ItemText { get; set; }

        public bool Completed { get; set; }
    }
}
