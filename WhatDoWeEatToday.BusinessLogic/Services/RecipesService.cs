using WhatDoWeEatToday.BusinessLogic.Dtos;
using WhatDoWeEatToday.BusinessLogic.Services.Contracts;
using WhatDoWeEatToday.DataAcess.Repositories.Contracts;

namespace WhatDoWeEatToday.BusinessLogic.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository _recipesRepository;

        public RecipesService(IRecipesRepository recipesRepository)
        {
            _recipesRepository = recipesRepository;
        }

        public List<RecipeDto> GetRecipesWithIngredient(string ingredient)
        {
            var recipes = _recipesRepository.GetRecipesWithIngredient(ingredient);

            var mappedRecipes = new RecipeDto();

            return mappedRecipes;
        }
    }
}
