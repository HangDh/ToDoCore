using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoCore.Data;
using ToDoCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoCore.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetItemsAsync()
        {
            var items = await _context.Items.ToArrayAsync();
            return items;
        }

        public async Task<TodoItem> GetItemIdAsync(Guid? id)
        {
            var item = await _context.Items
                .FirstOrDefaultAsync(i => i.Id == id);

            return item;
        }

        public async Task<bool> AddItemAsync(TodoItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDone = false;
            newItem.StartAt = DateTime.Now;

            _context.Items.Add(newItem);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> MarkDoneAsync(Guid id)
        {
            var item = await _context.Items
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (item == null) return false;

            item.IsDone = true;

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1; // One entity should have been updated
        }

        public async Task<bool> StopTaskAsync(Guid id)
        {
            var item = await _context.Items
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (item == null) return false;

            if (item.StopAt < DateTime.FromOADate(1)) {
                item.TimeSpend = DateTime.Now - item.StartAt;
            } else {
                item.TimeSpend += DateTime.Now - item.StopAt;
            }
            
            item.StopAt = DateTime.Now;
            
            if (item.StopAt < DateTime.FromOADate(1)) {
                item.TimeRem = item.DueAt - item.StartAt;
            } else {
                item.TimeRem = item.DueAt - item.StopAt;
            }

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1; // One entity should have been updated
        }
    }
}