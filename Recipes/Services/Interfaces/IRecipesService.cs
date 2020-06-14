using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface IRecipesService
    {
        Task<List<RecipesModel>> GetAllRecipesAsync();
    }
}
