using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWeekPlanner.Interfaces
{
    public interface ICommander
    {
        
        void Execute(Planner planner);
    }
}
