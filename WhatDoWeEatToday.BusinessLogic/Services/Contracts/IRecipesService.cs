using WhatDoWeEatToday.BusinessLogic.Dtos;

namespace WhatDoWeEatToday.BusinessLogic.Services.Contracts
{
    public interface IRecipesService
    {
        public List<RecipeDto> GetRecipesWithIngredient(string ingredient);
    }
}
