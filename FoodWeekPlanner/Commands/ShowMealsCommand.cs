using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWeekPlanner.Interfaces;

namespace FoodWeekPlanner.Commands
{
    public class ShowMealsCommand : ICommander
    {
        Dictionary<string, Meal> theseMeals = new Dictionary<string, Meal>();
        public void Execute(Planner planner)
        {
            Console.Clear();
            theseMeals = planner.GetMeals();
            if (theseMeals.Count == 0)
            {
                Console.WriteLine("Du har för närvarande inga måltider plannerade!");
            }
            
            foreach (Meal meal in theseMeals.Values)
            {
                
                Console.WriteLine(meal.Day);
                if (meal.Protein != "" && meal.Carb != "" && meal.Sallad != "" && meal.Sauce != "" && meal.Extras != "")
                {


                    meal.PrintInfo();
                    
                }
                else
                {
                    Console.WriteLine("Inget planerat än.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Tryck ENTER för att gå vidare");
            Console.ReadLine();
        }
    }
}
