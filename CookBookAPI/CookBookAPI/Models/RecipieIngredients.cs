using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBookAPI.Models
{
    public class RecipieIngredients
    {
        [Required]
        public int RecipieID { get; set; }
        [Required]
        public int IngredientsID { get; set; }
        [Column(TypeName = "varchar(max)")]
        [MaxLength]
        public string Quantity { get; set; }

        // Navigation
        public Recipes Recipe { get; set; }
        public Ingredients Ingredient { get; set; }
    }
}
