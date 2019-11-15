using System;
using TaxiStation.ConsoleMenu;
using TaxiStation.Models;
using System.Linq;

namespace TaxiStation
{
    class Program
    {
        delegate void method(TaxiStationModel taxiStation);

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
                methods[menuResult](taxiStation);
                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        static void GetPriceAllCars(TaxiStationModel taxiStation)
        {
            Console.WriteLine("Общая стоимость автомобилей в гараже составляет {0,8:#,#} BYN.", taxiStation.GetVehiclesTotalCost());
        }

        static void SortCarByFuelСonsumption(TaxiStationModel taxiStation)
        {
            taxiStation.GetSortedCars();
            
        }

        static void FindCarBySpeed(TaxiStationModel taxiStation)
        {
            Console.WriteLine("Выбрано действие 3");
        }

        static void BuyCar(TaxiStationModel taxiStation)
        {

        }

        static void Exit(TaxiStationModel taxiStation)
        {
            Console.WriteLine("Таксопарк заканчивает работу!");
        }

    }
}
