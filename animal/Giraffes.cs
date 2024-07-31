using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooMayhem
{
    class Giraffes : Animal
    {
        private double[] FeedingTimes = { 9.00, 15.00, 18.00 };

        public Giraffes(bool enclosedCage, int quantity) : base("Giraffes", enclosedCage, quantity)
        {
        }

        public override string GetPreferredFoodType()
        {
            return "vegan";
        }

        protected override int GetFoodAmount()
        {
            return Quantity * 2; 
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
