using System;
using System.Collections.Generic;
using TaxiStation.Vehicles;

namespace Shop.Models
{
    public class AutoShopModel
    {
        #region Fields
        //##################################################################################################################

        private Dictionary<int, CarForSaleModel> _carForSaleDict;       // dictionary Cars for sale


        #endregion // Fields




        #region PROPERTIES
        //##################################################################################################################



        #endregion // PROPERTIES




        #region CTOR
        //##################################################################################################################

        public AutoShopModel()
        {
            _carForSaleDict = SetVehicleForSaleRND();
        }





        #endregion // CTOR





        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Display RND Cars in AutoShop
        /// </summary>
        public void DisplayCarForSale()
        {
            Console.Clear();
            Console.WriteLine("АВТОМАГАЗИН");
            for (int i = 0; i < _carForSaleDict.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2:N} BYN", i, _carForSaleDict[i].Car.Brand.Name, _carForSaleDict[i].CurrentPrice);
            }
        }

        /// <summary>
        /// Сar sale process
        /// </summary>
        /// <param name="npp">Car Id in AutoShop</param>
        /// <returns>Sold Car</returns>
        public Car SaleCar(int npp)
        {
            if (!_carForSaleDict.ContainsKey(npp))
            {
                return null;
            }

            CarForSaleModel _saledCar = _carForSaleDict[npp];            
            _saledCar.Car.CurrentPrice = _saledCar.CurrentPrice;

            _carForSaleDict.Remove(npp);
            if (_carForSaleDict.Count < 1)
            {
                _carForSaleDict = SetVehicleForSaleRND();
            }
            DisplayCarForSale();
            return _saledCar.Car;
        }



        /// <summary>
        /// List of cars for sale and their prices
        /// </summary>
        /// <returns>New Dictionary Cars for sale</returns>
        private Dictionary<int, CarForSaleModel> SetVehicleForSaleRND()
        {
            Random rnd = new Random();
            int n_cars = rnd.Next(3, 5);     // Получить случайное число (в диапазоне от 3 до 5)

            Dictionary<int, CarForSaleModel> _tmpLst = new Dictionary<int, CarForSaleModel>();
            for (int i = 0; i < n_cars; i++)
            {
                _tmpLst.Add(i, new CarForSaleModel());
            }
            return _tmpLst;
        }


        #endregion // METHODS




    }
}
