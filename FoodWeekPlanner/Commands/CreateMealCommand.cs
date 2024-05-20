using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWeekPlanner.Interfaces;

namespace FoodWeekPlanner.Commands
{
    public class CreateMealCommand : ICommander
    {
       
        Dictionary<int, string> dayDic = new Dictionary<int, string>();
        string day = "";
        public void Execute(Planner planner)
        {
            dayDic.Add(1, "Måndag");

            Console.Clear();
            InputSingleton inputSingleton = InputSingleton.Instance;

            Console.WriteLine("Vilken dag du vill planera. Skriv nummer");
            Console.WriteLine("1. Måndag");
            Console.WriteLine("2. Tisdag");
            Console.WriteLine("3. Onsdag");
            Console.WriteLine("4. Torsdag");
            Console.WriteLine("5. Fredag");
            Console.WriteLine("6. Lördag");
            Console.WriteLine("7. Söndag");

            int val = inputSingleton.GetInt("Gör ditt val:");
            if (dayDic.ContainsKey(val))
            {
                day = dayDic[val];
            }
            else
            {
                Console.WriteLine("Du måste skriva en siffra mellan 1-7");
            }

            if (val == 1)
            {
                day = "Måndag";
            }
            if (val == 2)
            {
                day = "Tisdag";
            }
            if (val == 3)
            {
                day = "Onsdag";
            }
            if (val == 4)
            {
                day = "Torsdag";
            }
            if (val == 5)
            {
                day = "Fredag";
            }
            if (val == 6)
            {
                day = "Lördag";
            }
            if (val == 7)
            {
                day = "Söndag";
            }
            if (day == "")
            {
                Console.WriteLine("Du måste skriva en siffra mellan 1-7");
            }
            planner.Create(day);
        }
        
        
    }
}
