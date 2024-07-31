using System.Collections.Generic;
using System;

namespace ZooMayhem
{
    public static class Logic
    {

        /// <summary>
        /// 
        ///   добавить зависимость количества посещений от статуса
        ///   
        /// 
        /// </summary>





        private static Random _rnd = new Random();

        public static int Shop { get; private set; }
        public static int Cafe { get; private set; }
        public static int Cleaner { get; private set; }
        public static int Ticket { get; private set; }
        public static int DirtyIncome { get; private set; }
        public static int Expenses { get; set; }
        public static int CleanIncome { get; private set; }
        public static int TotalQuantityOfMeat { get; set; } = 100;
        public static int TotalQuantityOfVeganFood { get; set; } = 100;
        public static int Money { get; private set; } = 0;
        public static int Day { get; private set; } = 1;
        public static List<int> DailyEarnings { get; private set; } = new List<int>();
        public static List<int> DailyExpenses { get; private set; } = new List<int>();
        public static List<int> DailyClean { get; private set; } = new List<int>();
        public static int Status { get; private set; } = 50;
        public static bool ShopHireStatus { get; set; }
        public static bool CafeHireStatus { get; set; }
        public static bool CleanerHireStatus { get; set; }
        private static int ExpensesCalculation { get; set; } = 0;
        private static int EarningCalculation { get; set; } = 0;

        public static event EventHandler DayChanged;

        public static void ExpensesAndEarning()
        {
            Cafe = 0;
            Shop = 0;
            Cleaner = 0;
            if (CafeHireStatus)
            {
                ExpensesCalculation += 65;
                Cafe = _rnd.Next(50,80);
            }
            if (ShopHireStatus)
            {
                ExpensesCalculation += 50;
                Shop = _rnd.Next(40, 65);
            }
            if (CleanerHireStatus)
            {
                ExpensesCalculation += 40;
                Cleaner = _rnd.Next(30, 55); ;
            }
            EarningCalculation = Cafe + Shop + Cleaner ;
        }







        public static void Initialize()
        {
            ExpensesAndEarning(); 
            CalculateDailyIncome();
        }


        private static void CalculateDailyIncome()
        {
            Ticket = 50;
            DirtyIncome = EarningCalculation+Ticket;
            Expenses = 25 + ExpensesCalculation;
            CleanIncome = DirtyIncome - Expenses;
            Money += CleanIncome;
            ExpensesCalculation = 0;
            //EarningCalculation = 0;
            
        }


        public static void AddDailyEarnings(int dirtIncome)
        {
            DailyEarnings.Add(dirtIncome);
        }

        public static void AddDailyExpenses(int expenses)
        {
            DailyExpenses.Add(expenses);
        }

        public static void AddDailyClean(int cleanIncome)
        {
            DailyClean.Add(cleanIncome);
        }

        public static void DayChange(List<Animal> animals)
        {
            ExpensesAndEarning();


            AddDailyEarnings(DirtyIncome);
            AddDailyExpenses(Expenses);
            AddDailyClean(CleanIncome);
            
            CalculateDailyIncome();
            Day++;
            UpdateAnimalsDaysWithoutFood(animals);
            DayChanged?.Invoke(null, EventArgs.Empty);
        }

        private static void UpdateAnimalsDaysWithoutFood(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (!animal.IsFed)
                {
                    animal.DecreaseDaysWithoutFood();
                }
                else
                {
                    animal.DaysWithoutFood = 0;
                }
            }
        }

        public static void GetAnimalsStatus(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.DaysWithoutFood <= 1)
                {
                    Status += 5;
                }
                else if (animal.DaysWithoutFood == 2)
                {
                    Status -= 5;
                }
                else
                {
                    Status -= 10;
                }
            }
        }

        public static void DecreaseMeat(int meatQuantity)
        {
            if (TotalQuantityOfMeat < meatQuantity)
            {
                Console.WriteLine($"Error: Not enough meat left to feed the animals.");
            }
            else
            {
                TotalQuantityOfMeat -= meatQuantity;
                if (TotalQuantityOfMeat < 0)
                    TotalQuantityOfMeat = 0;
            }
        }

        public static void DisplayCurrentMeatQuantity()
        {
            Console.WriteLine($"Current quantity of meat: {TotalQuantityOfMeat}");
        }

        public static void DecreaseVeganFood(int veganQuantity)
        {
            TotalQuantityOfVeganFood -= veganQuantity;
            if (TotalQuantityOfVeganFood < 0)
                TotalQuantityOfVeganFood = 0;
        }

        public static void DisplayCurrentVeganQuantity()
        {
            Console.WriteLine($"Current quantity of non-meat: {TotalQuantityOfVeganFood}");
        }
    }
}