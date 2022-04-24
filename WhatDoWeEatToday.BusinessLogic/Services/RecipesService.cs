using WhatDoWeEatToday.BusinessLogic.Services.Contracts;
using WhatDoWeEatToday.Domain.Entities;

namespace WhatDoWeEatToday.BusinessLogic.Services
{
    public class RecipesService : IRecipesService
    {
        public List<Recipe> GetRecipesWithIngredient(string ingredient)
        {
            return new List<Recipe>();
        }
    }
}
