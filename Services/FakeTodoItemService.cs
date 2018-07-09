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
                StopAt = DateTime.Now + new TimeSpan(3,12,3),
                StartAt = DateTime.Now,
                DueAt = DateTime.Now + TimeSpan.FromDays(2),
                TimeSpend = new TimeSpan(3,12,3)
            };

            var item2 = new TodoItem
            {
                Title = "Build awesome apps",
                StopAt = DateTime.Now + new TimeSpan(2,11,33),
                StartAt = DateTime.Now,
                DueAt = DateTime.Now + TimeSpan.FromDays(2),
                TimeSpend = new TimeSpan(2,11,33)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}