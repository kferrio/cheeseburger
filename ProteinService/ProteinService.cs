using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodCalculus;

namespace KProteinService
{
    public class ProteinService : IProteinService
    {
        public string getProtein()
        {
            return "beef";
        }

        public int getCalories()
        {
            FoodCalc fc = new FoodCalc();
            return fc.getCalories;
        }
    }
}
