using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBookAPI.Models
{
    public class RecipieIngredients
    {
        public int RecipieID { get; set; }
        public int IngredientsID { get; set; }
        [Column(TypeName = "varchar(max)")]
        [MaxLength]
        public string Quantity { get; set; }

    }
}
