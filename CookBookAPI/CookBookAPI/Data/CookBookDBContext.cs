using CookBookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookAPI.Data
{
    public class CookBookDBContext : DbContext
    {
        public CookBookDBContext(DbContextOptions<CookBookDBContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipieIngredients>().HasKey(hr => new { hr.RecipieID, hr.IngredientsID});
        }

        DbSet<RecipieIngredients> RecipieIngredients { get; set; }

        DbSet<Ingredients> Ingredients { get; set; }
    }
}
