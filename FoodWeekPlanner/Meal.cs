using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWeekPlanner
{
    public class Meal
    {
        public string Day { get; set; }
        public string Protein { get; set; }
        public string Carb { get; set; }
        public string Sallad { get; set; }
        public string Sauce { get; set; }
        public string Extras { get; set; }

        public Meal(string day, string protein, string carb, string sallad, string sauce, string extras)
        {
            Day = day;
            Protein = protein;
            Carb = carb;
            Sallad = sallad;
            Sauce = sauce;
            Extras = extras;
        }
        public void PrintInfo()
        {
            SetNothing();
            Console.WriteLine("Protein: " + Protein + ". Kolydrat: " + Carb + ". Sallad: " + Sallad + ". Sauce: " + Sauce + ". Extra: " + Extras);
            Console.WriteLine();
        }

        private void SetNothing()
        {
            if (Protein == "")
            {
                Protein = "Inget";
            }
            if (Carb == "")
            {
                Carb = "Inget";
            }
            if (Sallad == "")
            {
                Sallad = "Inget";
            }
            if (Sauce == "")
            {
                Sauce = "Inget";
            }
            if (Extras == "")
            {
                Extras = "Inget";
            }
        }
    }
}
