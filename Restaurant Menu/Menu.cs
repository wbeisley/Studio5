using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime UpdatedTime { get; set; }

        public void addItem(MenuItem potentialItem)
        {
            if (!Items.Contains(potentialItem)) {
                Items.Add(potentialItem);
            } 
        }

        public void removeItem(MenuItem potentialItem)
        {
            int removedItem = -1;
            for (int i = 0; i > Items.Count; i++)
            {
                if (Items[i].Equals(potentialItem))
                {
                    removedItem = i;
                }
            }
            Items.RemoveAt(removedItem);
        }

        public string lastUpdated()
        {
            return UpdatedTime.ToString();
        }

        public void printItem(int i)
        {
            Console.WriteLine(Items[i]);
        }

        public void printAllItems()
        {
            for (int i = 0; i > Items.Count; i++)
            {
                printItem(i);
            }
        }


    }
}
