using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services.Interfaces
{
    public interface ILanguageModelsService
    {
        Task<List<LanguageModelsModel>> GetAllLanguageModelsAsync();
        Task<LanguageModelsModel> GetLanguageModelByIdAsync(Guid id);
        Task AddLanguageModelAsync(LanguageModelsModel languageModel);
        Task UpdateLanguageModelAsync(LanguageModelsModel languageModel);
        Task DeleteLanguageModelAsync(Guid id);
    }
}
