using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMayhem
{
    class Otters : Animal
    {
        private double[] FeedingTimes = { 9.00, 15.00, 18.00 };
        string theMostBeautifulOtterName = "Ksundrija";
        public Otters(bool enclosedCage, int quantity) : base("Otters", enclosedCage, quantity)
        {
        }

        public override string GetPreferredFoodType()
        {
            return "meat";
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