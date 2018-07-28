using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ToDoCore.Models;

namespace ToDoCore.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetItemsAsync(IdentityUser user);
        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
        Task<bool> StopTaskAsync(Guid id, IdentityUser user);
        Task<TodoItem> GetItemIdAsync(Guid? id, IdentityUser user);
    }
}