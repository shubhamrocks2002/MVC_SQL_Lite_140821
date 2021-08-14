using System;
using Microsoft.EntityFrameworkCore;

namespace DoteNetAzure.Data
{
public class MyDatabaseContext : DbContext
    {public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DoteNetAzure.Models.Todo> Todo { get; set; }

        internal object GetTodo()
        {
            throw new NotImplementedException();
        }
    }
}