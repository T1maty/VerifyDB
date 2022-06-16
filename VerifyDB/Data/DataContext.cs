using Microsoft.EntityFrameworkCore;
using VerifyDB.Entities;

namespace VerifyDB.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext>options) : base(options)
    {

    }

    public DbSet<User> Users => Set<User>();
}