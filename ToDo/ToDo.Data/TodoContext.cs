using Microsoft.EntityFrameworkCore;
using Todo.Domain;

namespace Todo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoContext).Assembly);


            base.OnModelCreating(modelBuilder);
        }

    }
}