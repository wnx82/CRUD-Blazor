using CRUD.Entities;
using Microsoft.EntityFrameworkCore;
namespace CRUD
{
    public class Database : DbContext
    {
        public DbSet<Employe> Employes { get; set; } = null!;

        public Database(DbContextOptions options) : base(options)
        {

        }
    }
}