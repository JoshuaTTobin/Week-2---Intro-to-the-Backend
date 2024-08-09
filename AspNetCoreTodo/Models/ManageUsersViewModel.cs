using System.Collections.Generic;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Models

{
    public class ManageUsersViewModel
    {
        // Help Items stop complaining about null p. 87
        public ManageUsersViewModel()
        {
            Administrators = Array.Empty<IdentityUser>();
            Everyone = Array.Empty<IdentityUser>();
        }
        public IdentityUser[] Administrators { get; set; }
        public IdentityUser[] Everyone { get; set; }
    }
}

//P.87 created new view model added code,