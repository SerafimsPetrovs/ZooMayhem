using System;
using ZooMayhem;

public abstract class Animal
{
    public string TypeOfAnimal { get; private set; }
    public int Quantity { get; private set; }
    public bool IsFed { get; set; }
    public bool EnclosedCage { get; private set; }
    public string TotalQuantityOfFood { get; set; }
    public int DaysWithoutFood { get; internal set; } 
    public bool DecisionMade { get; set; }
    private const int MaxDaysWithoutFood = 2; 

    public Animal(string typeOfAnimal, bool enclosedCage, int quantity)
    {
        Quantity = quantity;
        TypeOfAnimal = typeOfAnimal;
        EnclosedCage = enclosedCage;
        IsFed = false;
        DaysWithoutFood = 0;  
    }

    public abstract string GetPreferredFoodType();
    protected virtual int GetFoodAmount()
    {
        return Quantity;
    }

    public int GetFoodAmountPublicly()
    {
        return GetFoodAmount();
    }

    public virtual string Feed()
    {
        int amountToFeed = GetFoodAmount();
        if (GetPreferredFoodType() == "meat" && Logic.TotalQuantityOfMeat >= amountToFeed)
        {
            Logic.DecreaseMeat(amountToFeed);
            DaysWithoutFood = 0;  
            return $"{TypeOfAnimal} have been fed with {amountToFeed} units of meat.";
        }
        else if (GetPreferredFoodType() == "vegan" && Logic.TotalQuantityOfVeganFood >= amountToFeed)
        {
            Logic.DecreaseVeganFood(amountToFeed);
            DaysWithoutFood = 0;  
            return $"{TypeOfAnimal} have been fed with {amountToFeed} units of vegan food.";
        }
        else
        {
            return $"Error: Not enough {GetPreferredFoodType()} left to feed the animals.";
        }
    }

    public string GetDaysWithoutFood()
    {
        if (DaysWithoutFood <=1)
        {
            return $"{TypeOfAnimal} are feeling fine and are not hungry.";
        }
        else if (DaysWithoutFood ==2)
        {
            return $"{TypeOfAnimal} are very hungry.";
        }
        else
        {
            return $"{TypeOfAnimal} need to be fed IMMEDIATELY!";
        }
    }

    public void DecreaseDaysWithoutFood()
    {
        DaysWithoutFood++;
    }

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;
        if (Quantity < 0) Quantity = 0;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Animal: {TypeOfAnimal}\t Enclosed Cage: {EnclosedCage}\t Quantity: {Quantity}");
    }

    public virtual void UpdateMeatQuantity(int meatQuantity)
    {
        Logic.DecreaseMeat(meatQuantity);
    }

    public virtual void UpdateNonMeatQuantity(int nonMeatQuantity)
    {
        Logic.DecreaseVeganFood(nonMeatQuantity);
    }
}
