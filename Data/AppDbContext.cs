using Microsoft.EntityFrameworkCore;
using StravaApp.Models;

namespace StravaApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<MealEntry> MealEntries => Set<MealEntry>();
}