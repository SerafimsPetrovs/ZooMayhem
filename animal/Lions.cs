using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMayhem
{
    class Lions : Animal
    {

        public Lions(bool enclosedCage, int quantity) : base("Lions", enclosedCage, quantity)
        {
        }
        public override string GetPreferredFoodType()
        {
            return "meat";
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