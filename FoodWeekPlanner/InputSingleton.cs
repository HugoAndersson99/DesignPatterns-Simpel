using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWeekPlanner
{
    public class InputSingleton
    {
        public static InputSingleton Instance = new InputSingleton();

        private InputSingleton() { }

        public string GetString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine().ToUpper();
                if (input == null || input == "")
                {
                    Console.WriteLine("Skriv något.");
                    continue;
                }
                return input;
            }
        }

        public int GetInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                try
                {
                    return int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Skriv ett nummer tack.");
                }
            }
        }

        public bool GetBool(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine().ToLower();
                if (input == "true" || input == "y")
                {
                    return true;
                }
                if (input == "false" || input == "n")
                {
                    return false;
                }
                Console.WriteLine("Det är inget alternativ");
            }
        }
    }
}
