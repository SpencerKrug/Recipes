using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Data.Repositories.Interfaces
{
    public interface ILanguageModelsRepository
    {
        Task<List<LanguageModelsModel>> GetAllLanguageModelsAsync();
        Task<LanguageModelsModel> GetLanguageModelByIdAsync(Guid id);
        Task AddLanguageModelAsync(LanguageModelsModel languageModel);
        Task UpdateLanguageModelAsync(LanguageModelsModel languageModel);
        Task DeleteLanguageModelAsync(Guid id);
    }
}
