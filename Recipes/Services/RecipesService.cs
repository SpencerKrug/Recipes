using Recipes.Data.Models;
using Recipes.Data.Repositories.Interfaces;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository _repo;

        public RecipesService(IRecipesRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<RecipesModel>> GetAllRecipesAsync() =>
            await _repo.GetAllRecipesAsync();
    }
}
