using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == null)
            {
                return false;
            }
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            } 

            MenuItem m = toBeCompared as MenuItem;
            return m.Price == Price && 
                m.Description == Description && 
                m.Category == Category && 
                m.IsNew == IsNew;
        }

        public bool isNewItem()
        {
           return IsNew;
          
        }
    }
}
