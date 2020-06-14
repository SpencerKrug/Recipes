using Microsoft.EntityFrameworkCore;
using Recipes.Data.Contexts;
using Recipes.Data.Models;
using Recipes.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Data.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly RecipesDbContext _context;

        public RecipesRepository(RecipesDbContext context)
        {
            _context = context;
        }

        public async Task<List<RecipesModel>> GetAllRecipesAsync() =>
            await _context.RecipesContext.ToListAsync();
    }
}
