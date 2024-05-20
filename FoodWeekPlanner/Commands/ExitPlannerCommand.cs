using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWeekPlanner.Interfaces;

namespace FoodWeekPlanner.Commands
{
    public class ExitPlannerCommand : ICommander
    {
        public void Execute(Planner planner)
        {
            Environment.Exit(0);
        }
    }
}
