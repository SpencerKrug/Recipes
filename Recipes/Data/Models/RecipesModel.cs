using System;

namespace Recipes.Data.Models
{
    public class RecipesModel
    {
        public Guid RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeDirections { get; set; }
        public string RecipeUrl { get; set; }
        public string RecipeCategory { get; set; }
        public bool RecipeTested { get; set; }
        public string RecipeRating { get; set; }
    }
}
