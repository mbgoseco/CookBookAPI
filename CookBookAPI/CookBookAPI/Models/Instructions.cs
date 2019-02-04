using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookAPI.Models
{
    public class Instructions
    {
        public int RecipeID { get; set; }
        public int StepNumberID { get; set; }
        public string Action { get; set; }

        // Navigation
        public Recipes Recipe { get; set; }
    }
}
