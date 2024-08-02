using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);    // p.81

        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser currentUser);  // p. 67, 84

        Task<bool> MarkDoneAsync(Guid id, IdentityUser currentUser); // p. 72, 84
    }
}
// P. 32-33