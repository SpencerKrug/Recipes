using Recipes.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Data.Repositories.Interfaces
{
    public interface IRecipesRepository
    {
        Task<List<RecipesModel>> GetAllRecipesAsync();
    }
}
