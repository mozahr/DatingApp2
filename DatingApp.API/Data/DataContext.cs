using DatingApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options){}

    //Data context is modelfirst generated, you need to add the model class as 
    //a dbset and make a dotnet database update to update the database
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}