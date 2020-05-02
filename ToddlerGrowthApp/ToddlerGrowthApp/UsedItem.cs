using System;
namespace ToddlerGrowthApp
{
    enum TypeOfItem
    {
        toy,
        shoe,
        cloth
    }
    class UsedItem
    {
        #region Properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public string ItemColor { get; set; }
        public string ItemSize { get; set; }
        public string ItemDescription{ get; set; }
        public decimal ItemPrice { get; set; }
        public TypeOfItem ItemType { get; set; }
        public int Quantity { get; set; }
        #endregion
        #region Methods
        public void SellItem(string itemId)
        {
          
        }
        public void BuyItem(string itemId)
        {

        }
        #endregion


    }
}
