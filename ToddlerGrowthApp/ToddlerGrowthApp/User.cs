using System;
using System.Collections.Generic;

namespace ToddlerGrowthApp
{
    class User
    {
        //public Baby BabyId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; private set; }
        public ICollection<Baby> Babies { get; set; }

        public void AddBaby(Baby baby)
        {
            if (Babies == null)
            {
                Babies = new List<Baby>();
            }
            Babies.Add(baby);
        }

    }
}
