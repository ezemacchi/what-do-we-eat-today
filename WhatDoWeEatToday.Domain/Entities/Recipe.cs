namespace WhatDoWeEatToday.Domain.Entities
{
    public class Recipe
    {

        public string Name { get; set; }

        public List<IngredientAndQuantity> IngredientAndQuantity { get; set; }
    }
}
