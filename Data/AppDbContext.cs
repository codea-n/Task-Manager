// This line gives us access to Entity Framework Core (the tool that helps us use a database with C#)
using Microsoft.EntityFrameworkCore;

// This line lets this file see the TaskItem class (we created it in the Models folder)
using TaskManagerMVC.Models;

// This is a special folder (namespace) where we keep database-related files
namespace TaskManagerMVC.Data
{
    // This class will connect our TaskItem model to a real database
    // It must inherit from "DbContext" to do that
    public class AppDbContext : DbContext
    {
        // This is a constructor. It runs when the app starts.
        // It gives important connection settings to the base class (DbContext)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // This line says:
        // "Please make a database table called TaskItems to store TaskItem objects."
        // Think of it as a list of all our tasks in the database
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}