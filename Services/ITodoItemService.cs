using System;
using System.Threading.Tasks;
using ToDoCore.Models;

namespace ToDoCore.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetItemsAsync();
        Task<bool> AddItemAsync(TodoItem newItem);
        Task<bool> MarkDoneAsync(Guid id);
    }
}