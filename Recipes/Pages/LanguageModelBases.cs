using Microsoft.AspNetCore.Components;
using Recipes.Data.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Pages
{
    public class LanguageModelBases : ComponentBase
    {
        [Inject]
        public ILanguageModelsService _service { get; set; }

        public List<LanguageModelsModel> LanguageModelsList { get; set; }
        public LanguageModelsModel EditingModel { get; set; }
        public bool ShowForm { get; set; }

        protected override async Task OnInitializedAsync()
        {
            LanguageModelsList = await _service.GetAllLanguageModelsAsync();
        }

        protected void ShowAddForm()
        {
            EditingModel = new LanguageModelsModel { LanguageModelId = Guid.NewGuid() };
            ShowForm = true;
        }

        protected void ShowEditForm(LanguageModelsModel model)
        {
            EditingModel = new LanguageModelsModel
            {
                LanguageModelId = model.LanguageModelId,
                LanguageModelName = model.LanguageModelName,
                LanguageModelProvider = model.LanguageModelProvider,
                LanguageModelApiEndpoint = model.LanguageModelApiEndpoint,
                LanguageModelEnabled = model.LanguageModelEnabled
            };
            ShowForm = true;
        }

        protected void CancelForm()
        {
            EditingModel = null;
            ShowForm = false;
        }

        protected async Task SaveLanguageModelAsync()
        {
            var existing = await _service.GetLanguageModelByIdAsync(EditingModel.LanguageModelId);
            if (existing == null)
                await _service.AddLanguageModelAsync(EditingModel);
            else
                await _service.UpdateLanguageModelAsync(EditingModel);

            LanguageModelsList = await _service.GetAllLanguageModelsAsync();
            ShowForm = false;
            EditingModel = null;
        }

        protected async Task DeleteLanguageModelAsync(Guid id)
        {
            await _service.DeleteLanguageModelAsync(id);
            LanguageModelsList = await _service.GetAllLanguageModelsAsync();
        }
    }
}
