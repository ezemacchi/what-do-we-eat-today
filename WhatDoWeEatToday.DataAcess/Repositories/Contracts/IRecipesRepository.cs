using WhatDoWeEatToday.Domain.Entities;

namespace WhatDoWeEatToday.DataAcess.Repositories.Contracts
{
    public interface IRecipesRepository
    {
        public List<Recipe> GetRecipesWithIngredient(string ingredient);
    }
}
