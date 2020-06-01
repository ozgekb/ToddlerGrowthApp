using System;
using System.Collections.Generic;
using System.Linq;

namespace ToddlerGrowthApp
{
    static class ToddlerGrowth
    {
        private static ToddlerGrowthContext db = new ToddlerGrowthContext();
        /*
        public static UsedItem LoadItem(string itemName, string itemColor, string itemDescription, int itemPrice, TypeOfItem itemType, int quantity)
        {
            var usedItem = new UsedItem

            {
                ItemName = itemName,
                ItemColor = itemColor,
                ItemDescription = itemDescription,
                ItemPrice = itemPrice,
                ItemType = TypeOfItem.toy,
                Quantity = quantity
            };
            db.UsedItems.Add(usedItem);
            db.SaveChanges();
            return usedItem;
        }
       */
       /*
        public static Baby AddBaby(string babyName, SexOfBaby babySex,
            DateTime birthDate,string birthPlace,decimal birthWeight,
            decimal birthHeight, decimal birthHeadCircumference,string birthHospital,string doctorName)
        {
            var baby = new Baby

            {
                BabyName = babyName,
                BabySex = SexOfBaby.Female,
                BirthDate = birthDate,
                BirthPlace = birthPlace,
                BirthWeight= birthWeight,
                BirthHeight = birthHeight,
                //BirthHeadCircumference = birthHeadCircumference,
                //BirthHospital = birthHospital,
                //DoctorName = doctorName
            };
            db.Babies.Add(baby);
            db.SaveChanges();
            return baby;
        }
        */

        public static User AddUser(string name, string lastName, string email)
        {
            var user = new User

            {
                Name = name,
                LastName = lastName,
                Email = email,
            };
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        public static void UpdateUser(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }

        public static int GetUsersCount()
        {
            return db.Users.Count();
        }

        public static User GetUser(string userEmail)
        {
            return db.Users.Find(userEmail);
        }

    }
}


