using Microsoft.EntityFrameworkCore;
using SistemaGestao.Domain.Entities;

namespace SistemaGestao.Infra.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Produtos> Produtos { get; set; }
}