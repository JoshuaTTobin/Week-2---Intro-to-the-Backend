using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(TodoItem newItem);  // p. 67

        Task<bool> MarkDoneAsync(Guid id); // p. 72
    }
}
// P. 32-33