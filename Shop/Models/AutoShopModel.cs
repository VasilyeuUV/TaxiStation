using System;
using System.Collections.Generic;
using TaxiStation.Vehicles;

namespace Shop.Models
{
    public class AutoShopModel
    {
        #region Fields
        //##################################################################################################################

        private Dictionary<int, CarForSaleModel> _carForSaleDict;


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

        public void DisplayCarForSale()
        {
            Console.Clear();
            Console.WriteLine("АВТОМАГАЗИН");
            for (int i = 0; i < _carForSaleDict.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2:N} BYN", i, _carForSaleDict[i].Car.Brand.Name, _carForSaleDict[i].CurrentPrice);
            }
        }


        public Car SaleCar(int npp)
        {
            if (!_carForSaleDict.ContainsKey(npp))
            {
                DisplayCarForSale();
            }


            CarForSaleModel _saledCar = _carForSaleDict[npp];            
            _saledCar.Car.CurrentPrice = _saledCar.CurrentPrice;

            _carForSaleDict.Remove(npp);
            if (_carForSaleDict.Count < 1)
            {
                _carForSaleDict = SetVehicleForSaleRND();
            }
            return _saledCar.Car;
        }



        /// <summary>
        /// Car for sale List
        /// </summary>
        /// <returns></returns>
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
