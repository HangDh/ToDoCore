using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoCore.Models;

namespace ToDoCore.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1),
                StartAt = DateTime.Today,
                TimeSpend = new TimeSpan(3,12,3),
            };

            var item2 = new TodoItem
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2),
                StartAt = DateTime.Today,
                TimeSpend = new TimeSpan(2,15,22)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}