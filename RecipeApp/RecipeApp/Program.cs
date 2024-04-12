using System;

namespace RecipeApp
{
    // Class to represent an ingredient with name, quantity, and unit
    
    class Ingredient
    {
        public string Name { get; set; } // Name of the ingredient
        public double Quantity { get; set; } // Quantity of the ingredient
        public string Unit { get; set; } // Unit of measurement for the ingredient
    }

    // Class to represent a step in a recipe 
    
    class Step
    {
        public string Description { get; set; } // Description of the step
    }

    // Class to represent a recipe containing ingredients and steps
    
    class Recipe
    {
        private Ingredient[] ingredients; // Array to store ingredients
        private Step[] steps; // Array to store steps

        // Constructor to initialize arrays for ingredients and steps
        
        public Recipe()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
        }

        // Method to add ingredients to the recipe
        
        public void AddIngredients(int count)
        {
            ingredients = new Ingredient[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter name for ingredient {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter quantity for ingredient {i + 1}:");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter unit for ingredient {i + 1}:");
                string unit = Console.ReadLine();

                ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
            }
        }

        // Method to add steps to the recipe
        
        public void AddSteps(int count)
        {
            steps = new Step[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();

                steps[i] = new Step { Description = description };
            }
        }

        // Method to display the recipe including ingredients and steps
        
        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            foreach (var step in steps)
            {
                Console.WriteLine(step.Description);
            }
        }

        // Method to scale the recipe by a given factor
        
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to reset ingredient quantities to original values (not implemented)
        
        public void ResetQuantities()
        {
            // Reset quantities to original values
        }

        // Method to clear the recipe (reset ingredients and steps)
        public void ClearRecipe()
        {
            ingredients = new Ingredient[0];
            steps = new Step[0];
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            // Prompt user to enter the number of ingredients
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = Convert.ToInt32(Console.ReadLine());
            recipe.AddIngredients(ingredientCount);

            // Prompt user to enter the number of steps
            Console.WriteLine("Enter the number of steps:");
            int stepCount = Convert.ToInt32(Console.ReadLine());
            recipe.AddSteps(stepCount);

            // Display the recipe
            recipe.DisplayRecipe();

            // Prompt user to enter scaling factor
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
            double factor = Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            // Display the scaled recipe
            recipe.DisplayRecipe();

            // Prompt user to clear the recipe
            Console.WriteLine("Press any key to clear the recipe and enter a new one...");
            Console.ReadKey();
            recipe.ClearRecipe();
        }
    }
}
