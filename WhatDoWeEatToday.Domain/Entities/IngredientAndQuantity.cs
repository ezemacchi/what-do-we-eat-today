namespace WhatDoWeEatToday.Domain.Entities
{
    public class IngredientAndQuantity
    {
        public Ingredient Ingredient { get; set; }

        public decimal Amount { get; set; }

        public int RecipeId { get; set; }
    }
}