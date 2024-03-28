using CQRSSimple.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRSSimple.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<TaskItem> TaskItems { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
}