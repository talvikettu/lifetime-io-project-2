﻿using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models
{
    public class Users : IdentityUser
    {
        public string FullName {  get; set; }
    }
}