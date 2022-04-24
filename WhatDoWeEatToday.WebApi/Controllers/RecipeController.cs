using Microsoft.AspNetCore.Mvc;
using WhatDoWeEatToday.BusinessLogic.Services.Contracts;

namespace WhatDoWeEatToday.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipesService _recipesService;

        public RecipeController(IRecipesService recipeService)
        {
            _recipesService = recipeService;
        }

        [HttpGet("{ingredient}")]
        public IActionResult GetRecipesWithIngredient(string ingredient)
        {
            var recipes = _recipesService.GetRecipesWithIngredient(ingredient);

            return Ok(recipes);
        }
    }
}
