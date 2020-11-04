using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace TodoApi.Models
//{
//    public class TodoContext
//    {
//    }
//}
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
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