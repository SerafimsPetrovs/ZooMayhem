using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMayhem
{
    class Flamingos : Animal
    {
        private double[] FeedingTimes = { 9.00, 15.00 };
        private string typeOfFood = "vegan";

        public Flamingos(bool enclosedCage, int quantity) : base("Flamingos", enclosedCage, quantity)
        {
        }

        public override string GetPreferredFoodType()
        {
            return "vegan";
        }

        //public override void Feed()
        //{
        //    base.Feed();
        //}

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}