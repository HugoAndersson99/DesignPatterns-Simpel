using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWeekPlanner
{
    public class MealBuilder
    {
        private string Day { get; set; } = "";

        private string Protein { get; set; } = "";

        private string Carbs { get; set; } = "";
        private string Sallad { get; set; } = "";
        private string Sauce { get; set; } = "";
        private string Extras { get; set; } = "";

        public MealBuilder SetDay(string day)
        {
            Day = day;
            return this;
        }
        public MealBuilder SetProtein(string protein)
        {
            Protein = protein;
            return this;
        }
        public MealBuilder SetCarbs(string carbs)
        {
            Carbs = carbs;
            return this;
        }
        public MealBuilder SetSallad(string sallad)
        {
            Sallad = sallad;
            return this;
        }
        public MealBuilder SetSauce(string sauce)
        {
            Sauce = sauce;
            return this;
        }
        public MealBuilder SetExtras(string extras)
        {
            Extras = extras;
            return this;
        }

        public Meal Build()
        {
            return new Meal(Day, Protein, Carbs, Sallad, Sauce, Extras);
        }
    }
}
