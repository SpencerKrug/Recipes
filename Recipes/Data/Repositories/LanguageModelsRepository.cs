using Microsoft.EntityFrameworkCore;
using Recipes.Data.Contexts;
using Recipes.Data.Models;
using Recipes.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Data.Repositories
{
    public class LanguageModelsRepository : ILanguageModelsRepository
    {
        private readonly RecipesDbContext _context;

        public LanguageModelsRepository(RecipesDbContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModelsModel>> GetAllLanguageModelsAsync() =>
            await _context.LanguageModelsContext.ToListAsync();

        public async Task<LanguageModelsModel> GetLanguageModelByIdAsync(Guid id) =>
            await _context.LanguageModelsContext.FindAsync(id);

        public async Task AddLanguageModelAsync(LanguageModelsModel languageModel)
        {
            _context.LanguageModelsContext.Add(languageModel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLanguageModelAsync(LanguageModelsModel languageModel)
        {
            _context.LanguageModelsContext.Update(languageModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLanguageModelAsync(Guid id)
        {
            var languageModel = await _context.LanguageModelsContext.FindAsync(id);
            if (languageModel != null)
            {
                _context.LanguageModelsContext.Remove(languageModel);
                await _context.SaveChangesAsync();
            }
        }
    }
}
