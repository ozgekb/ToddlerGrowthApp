using System;

namespace ToddlerGrowthApp
{
    class Program
    {
        static void AddFirstUser() // Adds first test user to DB
        {
            var firstUser = ToddlerGrowth.AddUser("Ozge", "Kantar", "test@hotmail.com");

            DateTime birthdate = new DateTime(2018, 11, 05);
            Baby baby = new Baby("Ada", SexOfBaby.Female);
            firstUser.AddBaby(baby);
            ToddlerGrowth.UpdateUser(firstUser);
        }
        static void Main(string[] args)
        {
            //var firstItem = ToddlerGrowth.LoadItem("car", "red", "its a red small car with remote control",5,ToddlerGrowthApp.TypeOfItem.toy,1);
            //var firstBaby = ToddlerGrowth.AddBaby("car", "red", "its a red small car with remote control", 5, ToddlerGrowthApp.TypeOfItem.toy, 1);

            int usersCount = ToddlerGrowth.GetUsersCount();
            if (usersCount == 0) // Add test data to DB
            {
                AddFirstUser();
            }

            Console.WriteLine("Welcome to Baby Tracker App");
            Console.WriteLine("Pleae enter your email: ");
            string userEmail = Console.ReadLine();

            // Get user from DB:
            User user = ToddlerGrowth.GetUser(userEmail);
            Console.WriteLine("Welcome " + user.Name);
            Console.WriteLine("How can I help you? Please select an option below: ");
        }
    }
}
