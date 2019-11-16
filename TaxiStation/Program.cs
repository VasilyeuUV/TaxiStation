using Shop.Models;
using System;
using TaxiStation.ConsoleMenu;
using TaxiStation.Models;

namespace TaxiStation
{
    class Program
    {
        delegate void method(TaxiStationModel ts);

        static void Main(string[] args)
        {
            // Create new TaxiStation
            string fileName = @"filename.ext";          // file stub (заглушка для файла)           
            TaxiStationModel taxiStation = TaxiStationInitializer.CreateTaxiStation(fileName);

            // MENU
            string[] items = { "Стоимость автопарка", "Сортировать автомобили по расходу топлива", "Поиск автомобиляей по скорости", "Новый список автомобилей", "Выход" };
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

        static void GetPriceAllCars(TaxiStationModel ts)
        {
            Console.WriteLine("Общая стоимость автомобилей в гараже составляет {0,8:#,#} BYN.", ts.GetVehiclesTotalCost());
        }

        static void SortCarByFuelСonsumption(TaxiStationModel ts)
        {
            string result = ts.GetSortedCars();
            Console.WriteLine(result);
            Console.WriteLine();
        }

        static void FindCarBySpeed(TaxiStationModel ts)
        {
            Console.WriteLine("Поиск автомобиля в диапазоне скоростей:");
            int from = 0, to = 0;            
            do
            {
                Console.Write("Максимальная скорость от: ");
                try
                {
                    from = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    from = 0;
                }                
                if (from < 1 || from > 300)
                {
                    Console.Write("Недопустимое значение. Уточните значение.");
                    ClearCurrentConsoleLine();
                }
            } while (from < 1 || from > 300);
            ClearCurrentConsoleLine();
            Console.WriteLine(String.Format("- от: {0} км/ч", from));
            Console.WriteLine();
            ClearCurrentConsoleLine();

            Console.Write("Максимальная скорость до: ");
            try
            {
                to = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                to = from;
            }
            if (to < from || to > 300)
            {
                to = from;
            }
            ClearCurrentConsoleLine();
            Console.WriteLine(String.Format("- до: {0} км/ч", to));

            Console.WriteLine();
            string result = ts.FindVehiclesBySpeed(from, to);
            Console.WriteLine(result);
        }

        static void BuyCar(TaxiStationModel ts)
        {
            ts.Garage.Vehicles.Clear();
            AutoShopModel autoShop = new AutoShopModel();
            for (int i = 0; i < 3; i++)                         // добавим автомобили в гараж
            {
                ts.Garage.AddVehicle(ts.BuyCar(autoShop));
            }
            Console.WriteLine("Список автомобилей обновлён.");
        }

        static void Exit(TaxiStationModel ts)
        {
            Console.WriteLine("Таксопарк заканчивает работу!");
        }

        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop - 1;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
