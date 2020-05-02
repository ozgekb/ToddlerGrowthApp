using System;

namespace ToddlerGrowthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstItem = ToddlerGrowth.LoadItem("car", "red", "its a red small car with remote control",5,ToddlerGrowthApp.TypeOfItem.toy,1);
        }
    }
}
