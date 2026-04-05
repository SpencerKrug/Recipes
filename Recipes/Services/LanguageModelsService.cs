using Recipes.Data.Models;
using Recipes.Data.Repositories.Interfaces;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Services
{
    public class LanguageModelsService : ILanguageModelsService
    {
        private readonly ILanguageModelsRepository _repo;

        public LanguageModelsService(ILanguageModelsRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<LanguageModelsModel>> GetAllLanguageModelsAsync() =>
            await _repo.GetAllLanguageModelsAsync();

        public async Task<LanguageModelsModel> GetLanguageModelByIdAsync(Guid id) =>
            await _repo.GetLanguageModelByIdAsync(id);

        public async Task AddLanguageModelAsync(LanguageModelsModel languageModel) =>
            await _repo.AddLanguageModelAsync(languageModel);

        public async Task UpdateLanguageModelAsync(LanguageModelsModel languageModel) =>
            await _repo.UpdateLanguageModelAsync(languageModel);

        public async Task DeleteLanguageModelAsync(Guid id) =>
            await _repo.DeleteLanguageModelAsync(id);
    }
}
