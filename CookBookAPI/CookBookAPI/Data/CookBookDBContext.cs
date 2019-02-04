using CookBookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookAPI.Data
{
    public class CookBookDBContext : DbContext
    {
        public CookBookDBContext(DbContextOptions<CookBookDBContext> options) : base(options)
        {


        }

        DbSet<RecipieIngredients> RecipieIngredients { get; set; }
    }
}
