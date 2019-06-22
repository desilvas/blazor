using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class ToDoService
    {
        public Task<List<ToDo>> GetToDos()
        {
            var list = new ToDo[]
            {
                new ToDo
                {
                    Id = 1,
                    Completed = true,
                    ItemText = "This is the first item"
                },

               new ToDo
                {
                    Id = 2,
                    Completed = false,
                    ItemText = "This is the second item"
                }
            };

            return Task.FromResult(list.ToList());

        }
    }
}
