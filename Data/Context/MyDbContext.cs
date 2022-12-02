using Estudiantes20111179.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudiantes20111179.Data.Context;
public class MyDbContext:DbContext,IMyDbContext
{
    public MyDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Estudiantes> Estudiantes {get; set;} = null!;

    public virtual DbSet<Carrera> Carrera {get; set;} = null!;
   
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
public interface IMyDbContext
{
    public DbSet<Estudiantes> Estudiantes {get; set;}
    public  DbSet<Carrera> Carrera {get; set;}

    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}