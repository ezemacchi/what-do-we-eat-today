using WhatDoWeEatToday.BusinessLogic.Dtos;
using WhatDoWeEatToday.BusinessLogic.Services.Contracts;

namespace WhatDoWeEatToday.BusinessLogic.Services
{
    public class RecipesService : IRecipesService
    {
        public List<RecipeDto> GetRecipesWithIngredient(string ingredient)
        {
            return new List<RecipeDto>();
        }
    }
}
