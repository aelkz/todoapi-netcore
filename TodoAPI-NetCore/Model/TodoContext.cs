﻿using System;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI_NetCore.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
