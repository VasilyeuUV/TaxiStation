using System;
using TaxiStation.ConsoleMenu;
using TaxiStation.Models;

namespace TaxiStation
{
    class Program
    {
        delegate void method();

        static void Main(string[] args)
        {

            // Create new TaxiStation
            TaxiStationModel taxiStation = new TaxiStationModel();

            // MENU
            string[] items = { "Стоимость автопарка", "Сортировать автомобили по расходу топлива", "Поиск автомобиля", "Купить автомобиль", "Выход" };
            method[] methods = new method[] { GetPriceAllCars, SortCarByFuelСonsumption, FindCarBySpeed, BuyCar, Exit };
            Menu menu = new Menu(items);
            int menuResult;
            do
            {
                menuResult = menu.PrintMenu(taxiStation);
                Console.WriteLine();
                methods[menuResult]();
                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        static void GetPriceAllCars()
        {
            Console.WriteLine("Общая стоимость автомобилей в гараже составляет {0} BYN.", "\"Нет данных\"");
        }

        static void SortCarByFuelСonsumption()
        {
            Console.WriteLine("Выбрано действие 2");
        }

        static void FindCarBySpeed()
        {
            Console.WriteLine("Выбрано действие 3");
        }

        static void BuyCar()
        {

        }

        static void Exit()
        {
            Console.WriteLine("Приложение заканчивает работу!");
        }

    }
}
