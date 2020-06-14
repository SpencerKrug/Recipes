using Microsoft.AspNetCore.Components;
using Recipes.Data.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Pages
{
    public class RecipeBases : ComponentBase
    {
        [Inject]
        public IRecipesService _service { get; set; }

        public List<RecipesModel> RecipesList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RecipesList = await _service.GetAllRecipesAsync();
        }
    }
}
