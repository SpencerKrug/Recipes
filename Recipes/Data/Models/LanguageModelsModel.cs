using System;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Data.Models
{
    public class LanguageModelsModel
    {
        [Key]
        public Guid LanguageModelId { get; set; }
        [Required]
        [MaxLength(256)]
        public string LanguageModelName { get; set; }
        [MaxLength(256)]
        public string LanguageModelProvider { get; set; }
        [MaxLength(2048)]
        public string LanguageModelApiEndpoint { get; set; }
        public bool LanguageModelEnabled { get; set; }
    }
}
