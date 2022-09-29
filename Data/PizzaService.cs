using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<List<PizzaData>> GetPizzasAsync()
    {
        var pizzaSpecial = new List<PizzaData>()
        {
            new PizzaData{PizzaId = 1, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 2, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 3, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 4, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 5, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false}
        };
        // pizzaSpecial.AddRange(new List<PizzaData>
        // {

        //     // new PizzaSpecial { Name = "The Baconatorizor", BasePrice =  11.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
        //     // new PizzaSpecial { Name = "Buffalo chicken", BasePrice =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl="img/pizzas/meaty.jpg"},
        //     // new PizzaSpecial { Name = "Veggie Delight", BasePrice =  11.5M, Description = "It's like salad, but on a pizza", ImageUrl="img/pizzas/salad.jpg"},
        //     // new PizzaSpecial { Name = "Margherita", BasePrice =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl="img/pizzas/margherita.jpg"},
        //     // new PizzaSpecial { Name = "Basic Cheese Pizza", BasePrice =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", ImageUrl="img/pizzas/cheese.jpg"},
        //     // new PizzaSpecial { Name = "Classic pepperoni", BasePrice =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl="img/pizzas/pepperoni.jpg" }               
        // });
        return pizzaSpecial;
    }
}