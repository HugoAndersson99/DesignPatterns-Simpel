using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWeekPlanner.Interfaces;
using FoodWeekPlanner.Commands;

namespace FoodWeekPlanner
{
    public class Planner
    {
        bool running = true;

        List<string> protein = new List<string>();
        List<string> carbs = new List<string>();
        List<string> sallad = new List<string>();
        List<string> sauce = new List<string>();
        List<string> extras = new List<string>();
        Dictionary<string, Meal> meals = new Dictionary<string, Meal>();

        List<string> print = new List<string>();
        Dictionary<string, ICommander> choiceDictionary = new Dictionary<string, ICommander>();

        public Planner()
        {
            Load();

            print.Add("Vad vill du göra? Skriv ett nummer");
            print.Add("1. Planera dina måltider");
            print.Add("2. Se din veckoplannering");
            print.Add("3. Avsluta programmet");

            choiceDictionary.Add("1", new CreateMealCommand());
            choiceDictionary.Add("2", new ShowMealsCommand());
            choiceDictionary.Add("3", new ExitPlannerCommand());
        }

        public void MainMenu()
        {
            Console.Clear();
            while (running)
            {
                foreach (string text in print)
                {
                    Console.WriteLine(text);
                }
                string choice = Console.ReadLine();
                if (choiceDictionary.ContainsKey(choice))
                {
                    choiceDictionary[choice].Execute(this);
                }
                else
                {
                    Console.WriteLine("Det var inget alternativ");
                }
                Console.WriteLine();
            }
        }
        public void Create(string day)
        {
            Console.Clear();
            Console.WriteLine("Planerar måltid för " + day);
            MealBuilder builder = new MealBuilder();
            
            string protein = ChooseProtein();
            string carbs = ChooseCarbs();
            string sallad = ChooseSallad();
            string sauce = ChooseSauce();
            string extra = ChooseExtras();
            if (day != null)
            {
                builder.SetDay(day);
            }
            if (protein != "" || protein != null)
            {
                builder.SetProtein(protein);
                
            }
            
            if (carbs != null || carbs != "")
            {
                builder.SetCarbs(carbs);
            }
            if (sallad != null || sallad != "")
            {
                builder.SetSallad(sallad);
            }
            if (sauce != null || sauce != "")
            {
                builder.SetSauce(sauce);
            }
            if (extra != null || extra != "")
            {
                builder.SetExtras(extra);
            }
            Meal builtMeal = builder.Build();
            //builtMeal.Day = day;
            if (meals.ContainsKey(day))
            {
                meals.Remove(day);
            }
            meals.Add(builtMeal.Day, builtMeal);
            Console.WriteLine("Planerat klart för " + day + ". Lagd till: ");
            builtMeal.PrintInfo();
        }
        private void SetOrder(Dictionary<string, Meal> meal)
        {
            if (meal.ContainsKey("Måndag"))
            {
                
            }
        }

        private string ChooseProtein()
        {
            bool correct = false;
            int i = 0;
            InputSingleton inputSingleton = InputSingleton.Instance;

            while (true)
            {
                bool wantProtein = inputSingleton.GetBool("Vill du ha protein? y/n");
                if (wantProtein)
                {
                    foreach (string proteiner in protein)
                    {
                        i++;
                        Console.WriteLine(proteiner);
                    }
                    string proteinChoiche = inputSingleton.GetString("Gör ett val. Skriv proteinet");
                    foreach (string proteiner in protein)
                    {
                        if (proteiner == proteinChoiche)
                        {
                            correct = true;
                            Console.WriteLine("Lagd till " + proteinChoiche);
                            return proteinChoiche;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Det proteinet finns ej.");
                    }

                }
                else
                {
                    return "";
                }
            }
        }
        private string ChooseCarbs()
        {
            bool correct = false;
            int i = 0;
            InputSingleton inputSingleton = InputSingleton.Instance;

            while (true)
            {
                bool want = inputSingleton.GetBool("Vill du ha Kolhydrater? y/n");
                if (want)
                {
                    foreach (string kolhydrat in carbs)
                    {
                        i++;
                        Console.WriteLine(kolhydrat);
                    }
                    string choiche = inputSingleton.GetString("Gör ett val. Skriv Kolhydratens namn");
                    foreach (string kolhydrat in carbs)
                    {
                        if (kolhydrat == choiche)
                        {
                            correct = true;
                            Console.WriteLine("Lagd till " + choiche);
                            return choiche;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Det valet finns ej.");
                    }

                }
                else
                {
                    return "";
                }
            }
        }
        private string ChooseSallad()
        {
            bool correct = false;
            int i = 0;
            InputSingleton inputSingleton = InputSingleton.Instance;

            while (true)
            {
                bool want = inputSingleton.GetBool("Vill du ha Sallad? y/n");
                if (want)
                {
                    foreach (string sallader in sallad)
                    {
                        i++;
                        Console.WriteLine(sallader);
                    }
                    string choiche = inputSingleton.GetString("Gör ett val. Skriv salladens namn");
                    foreach (string sallader in sallad)
                    {
                        if (sallader == choiche)
                        {
                            correct = true;
                            Console.WriteLine("Lagd till " + choiche);
                            return choiche;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Det valet finns ej.");
                    }

                }
                else
                {
                    return "";
                }
            }
        }
        private string ChooseSauce()
        {
            bool correct = false;
            int i = 0;
            InputSingleton inputSingleton = InputSingleton.Instance;

            while (true)
            {
                bool want = inputSingleton.GetBool("Vill du ha sås? y/n");
                if (want)
                {
                    foreach (string sås in sauce)
                    {
                        i++;
                        Console.WriteLine(sås);
                    }
                    string choiche = inputSingleton.GetString("Gör ett val. Skriv såsens namn");
                    foreach (string sås in sauce)
                    {
                        if (sås == choiche)
                        {
                            correct = true;
                            Console.WriteLine("Lagd till " + choiche);
                            return choiche;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Det valet finns ej.");
                    }

                }
                else
                {
                    return "";
                }
            }
        }
        private string ChooseExtras()
        {
            bool correct = false;
            int i = 0;
            InputSingleton inputSingleton = InputSingleton.Instance;

            while (true)
            {
                bool want = inputSingleton.GetBool("Vill du ha något extra? y/n");
                if (want)
                {
                    foreach (string extra in extras)
                    {
                        i++;
                        Console.WriteLine(extra);
                    }
                    string choiche = inputSingleton.GetString("Gör ett val. Skriv valets namn");
                    foreach (string extra in extras)
                    {
                        if (extra == choiche)
                        {
                            correct = true;
                            Console.WriteLine("Lagd till " + choiche);
                            return choiche;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Det valet finns ej.");
                    }

                }
                else
                {
                    return "";
                }
            }
        }
        public Dictionary<string, Meal> GetMeals()
        {
            return meals;
        }
        private void Load()
        {
            protein.Add("FALUKORV");
            protein.Add("KYCKLING");
            protein.Add("KÖTTFÄRS");
            protein.Add("FLÄSKKÖTT");
            protein.Add("NÖTKÖTT");
            protein.Add("FISK");


            carbs.Add("RIS");
            carbs.Add("POTATIS");
            carbs.Add("PASTA");
            carbs.Add("COUSCOUS");
            carbs.Add("NUDLAR");


            sallad.Add("SPENAT");
            sallad.Add("TOMAT");
            sallad.Add("MOROT");
            sallad.Add("ISBERGSSALLAD");
            sallad.Add("GURKA");


            sauce.Add("BEARNEISESÅS");
            sauce.Add("MANGORAJA");
            sauce.Add("ROMSÅS");
            sauce.Add("KETCHUP");
            sauce.Add("VITLÖKSÅS");


            extras.Add("BRÖD");
            extras.Add("KNÄCKEBRÖD");
            extras.Add("ÄGG");
            extras.Add("ADVOKADO");
            extras.Add("OST");
            extras.Add("FRÖN");

            Quicksort quicksort = new Quicksort();
            quicksort.Sort(protein);
            quicksort.Sort(carbs);
            quicksort.Sort(sallad);
            quicksort.Sort(sauce);
            quicksort.Sort(extras);
            Meal måndag = new Meal("Måndag", "", "", "", "", ""); //Lägger in placeholders för att det ska visas i rätt ordning senare
            Meal tisdag = new Meal("Tisdag", "", "", "", "", "");
            Meal onsdag = new Meal("Onsdag", "", "", "", "", "");
            Meal torsdag = new Meal("Torsdag", "", "", "", "", "");
            Meal fredag = new Meal("Fredag", "", "", "", "", "");
            Meal lördag = new Meal("Lördag", "", "", "", "", "");
            Meal söndag = new Meal("Söndag", "", "", "", "", "");
            meals.Add("Måndag", måndag);
            meals.Add("Tisdag", tisdag);
            meals.Add("Onsdag", onsdag);
            meals.Add("Torsdag", torsdag);
            meals.Add("Fredag", fredag);
            meals.Add("Lördag", lördag);
            meals.Add("Söndag", söndag);
        }
    }
}
