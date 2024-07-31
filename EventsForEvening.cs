using System;
using System.Collections.Generic;

namespace ZooMayhem
{
    class EventsForEvening
    {
        private static Random rnd = new Random();

        public static string FindFoodEvent(bool userChoice)
        {
            if (userChoice)
            {
                int eventOutcome = rnd.Next(1, 11);

                if (eventOutcome <= 6)
                {
                    return "You found nothing unusual during your walk. Better luck next time!";
                }
                else if (eventOutcome == 7 || eventOutcome == 8)
                {
                    int foundMeat = rnd.Next(3, 9);
                    int foundVeganFood = rnd.Next(2, 8);
                    return $"Today you decided to go around the zoo grounds and check if everything is in order. In one of the old storerooms, hidden behind thick bushes, you find forgotten food supplies!\nMeat: {foundMeat} Non-meat: {foundVeganFood}";
                }
                else
                {
                    return "As you walk around the zoo, you hear a sudden noise in the bushes.\nStartled, you decide to run back to your quarters as quickly as possible!";
                }
            }
            else
            {
                return "Today you decided not to seek unnecessary adventures and went to bed.";
            }
        }

        public static string TraderEvent(List<Animal> zooAnimals)
        {
            int costMeat = rnd.Next(1, 8);
            int costVegan = rnd.Next(1, 8);

            Animal selectedAnimal = zooAnimals[rnd.Next(zooAnimals.Count)];

            return $"Today before the zoo closed, you were visited by a man who introduced himself as the owner of a private zoo.\nHe wants to buy one of your {selectedAnimal.TypeOfAnimal} for {costMeat} pieces of meat and {costVegan} pieces of non-meat.\nDo you want to sell this animal?";
        }

        public static string HandleTraderChoice(List<Animal> zooAnimals, bool userChoice)
        {
            int costMeat = rnd.Next(1, 8);
            int costVegan = rnd.Next(1, 8);

            Animal selectedAnimal = zooAnimals[rnd.Next(zooAnimals.Count)];

            if (userChoice)
            {
                if (selectedAnimal.Quantity > 0)
                {
                    selectedAnimal.DecreaseQuantity(1);
                    Logic.TotalQuantityOfMeat += costMeat;
                    Logic.TotalQuantityOfVeganFood += costVegan;
                    return $"You sold one {selectedAnimal.TypeOfAnimal}. Now you have {Logic.TotalQuantityOfMeat} pieces of meat and {Logic.TotalQuantityOfVeganFood} pieces of non-meat.";
                }
                else
                {
                    return "You don't have any animals of that type left in your zoo.";
                }
            }
            else
            {
                return "You turned down the strange offer and walked away proudly.";
            }
        }

        public static string NeedMedicEvent()
        {
            return "Medic!!\nIn progress :(";
        }

        public static string FoodDelivery()
        {
            Logic.TotalQuantityOfMeat += 4;
            Logic.TotalQuantityOfVeganFood += 4;
            return "Today is feed delivery day! The delivery guy brought you the usual amount of pet food.\n" +
                   $"Current Meat Quantity: {Logic.TotalQuantityOfMeat}\n" +
                   $"Current Vegan Food Quantity: {Logic.TotalQuantityOfVeganFood}";
        }

        public static string EventShuffle(List<Animal> zooAnimals, out string eventType)
        {
            int eventIndex = rnd.Next(1, 6);

            
                switch (eventIndex)
                {
                    case 1:
                        eventType = "None";
                        return "Nothing happened today. You peacefully went to bed, relieved that no lions asked for a nightcap.";
                    case 2:
                        eventType = "FindFood";
                        return "You have an opportunity to find food. Do you want to explore?";
                    case 3:
                        eventType = "Trader";
                        return TraderEvent(zooAnimals);
                    case 4:
                        eventType = "NeedMedic";
                        return NeedMedicEvent();
                    case 5:
                        eventType = "FoodDelivery";
                        return FoodDelivery();
                    default:
                        eventType = "Error";
                        return "Error, but why? Looks like the coder is dumb.";
                }
            }
        }
    }



//public static string EventShuffle(List<Animal> zooAnimals, out string eventType)
//{
//    int eventIndex = rnd.Next(1, 11);

//    if (eventIndex <= 6)
//    {
//        eventType = "None";
//        return "Nothing happened today. You peacefully went to bed, relieved that no lions asked for a nightcap.";
//    }
//    else
//    {
//        switch (eventIndex)
//        {
//            case 7:
//                eventType = "FindFood";
//                return "You have an opportunity to find food. Do you want to explore?";
//            case 8:
//                eventType = "Trader";
//                return TraderEvent(zooAnimals);
//            case 9:
//                eventType = "NeedMedic";
//                return NeedMedicEvent();
//            case 10:
//                eventType = "FoodDelivery";
//                return FoodDelivery();
//            default:
//                eventType = "Error";
//                return "Error, but why? Looks like the coder is dumb.";
//        }
//    }
//}
