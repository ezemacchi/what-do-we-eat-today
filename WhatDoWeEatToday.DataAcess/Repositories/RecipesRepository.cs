using WhatDoWeEatToday.DataAcess.Repositories.Contracts;
using WhatDoWeEatToday.Domain.Entities;

namespace WhatDoWeEatToday.DataAcess.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        public List<Recipe> GetRecipesWithIngredient(string ingredient)
        {
            throw new NotImplementedException();
        }
    }
}