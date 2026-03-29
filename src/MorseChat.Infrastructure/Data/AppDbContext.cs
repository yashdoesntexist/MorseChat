using Microsoft.EntityFrameworkCore;
using MorseChat.Domain.Entities;


namespace MorseChat.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}