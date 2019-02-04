using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookBookAPI.Models
{
    public class Ingredients
    {
        public int ID { get; set;}
        [Column(TypeName = "varchar(max)")]
        [MaxLength]
        public string Name { get; set; }

        // Navigation Properties
        public ICollection<RecipieIngredients> RecipeID { get; set; }
    }
}
