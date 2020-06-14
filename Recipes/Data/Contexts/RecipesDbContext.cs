using Microsoft.EntityFrameworkCore;
using Recipes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Data.Contexts
{
    public class RecipesDbContext : DbContext
    {
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base(options) { }

        public DbSet<RecipesModel> RecipesContext { get; set; }
    }
}
