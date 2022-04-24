using WhatDoWeEatToday.Domain.Entities;

namespace WhatDoWeEatToday.BusinessLogic.Services.Contracts
{
    public interface IRecipesService
    {
        public List<Recipe> GetRecipesWithIngredient(string ingredient);
    }
}
