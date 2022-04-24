namespace WhatDoWeEatToday.Domain.Entities
{
    public class Ingredient
    {
        public string Name { get; set; }

        public bool IsVeggie { get; set; }

        public bool IsVegan { get; set; }

        public int IngredientAndQuantityId { get; set; }
    }
}