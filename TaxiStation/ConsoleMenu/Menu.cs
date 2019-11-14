using System;

namespace TaxiStation.ConsoleMenu
{
    class Menu
    {

        #region FIELDS
        //##################################################################################################################

        string[] menuItems;
        int counter = 0;

        #endregion // FIELDS



        #region CTOR
        //##################################################################################################################

        public Menu(string[] menuItems)
        {
            this.menuItems = menuItems;
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Temporary Control TaxiStation
        /// </summary>
        /// <param name="taxiStation"></param>
        /// <returns></returns>
        public int PrintMenu(Models.TaxiStationModel taxiStation)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();

                Console.WriteLine("ТАКСОПАРК. Управление.");
                Console.WriteLine();

                ViewAutoPark(taxiStation);                

                // MENU
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (counter == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(menuItems[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.WriteLine(menuItems[i]);
                }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                    if (counter == -1) counter = menuItems.Length - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                    if (counter == menuItems.Length) counter = 0;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    return menuItems.Length - 1;                    
                }
            }
            while (key.Key != ConsoleKey.Enter);
            return counter;
        }

        /// <summary>
        /// View vehicles in the Garage
        /// </summary>
        private void ViewAutoPark(Models.TaxiStationModel taxiStation)
        {
            Console.WriteLine(taxiStation.ViewGarageAutopark());
            Console.WriteLine();
        }

        #endregion // METHODS


    }
}
