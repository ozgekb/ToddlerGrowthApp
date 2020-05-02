using System;
namespace ToddlerGrowthApp
{
    static class ToddlerGrowth
    {
        private static ToddlerGrowthContext db = new ToddlerGrowthContext();
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
    }
}