using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem appOne = new MenuItem(15, "Ceviche", "Appetizer", true);
            MenuItem appTwo = new MenuItem(18, "Lamb Skewer", "Appetizer", false);
            MenuItem entOne = new MenuItem(16, "Heart of Palm Salad", "Entree", true);
            MenuItem entTwo = new MenuItem(24, "Squid Ink Pasta", "Entree", true);
            MenuItem desOne = new MenuItem(18, "Whole Branzino", "Entree", false);
            MenuItem desTwo = new MenuItem(18, "Panna Cotta", "Desert", false);

            //Console.WriteLine($"MENU\n*\n${appOne.Price}, {appOne.Description}, {appOne.Category}, {appOne.Recent}");
            //Console.WriteLine($"*\n${appTwo.Price}, {appTwo.Description}, {appTwo.Category}, {appTwo.Recent}");

            
        

           
        }

    }
    
}
