using Machinery.Vehicles;
using Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiStation.Models
{
    public class TaxiStationModel
    {

        #region FIELDS
        //##################################################################################################################

        private GarageModel _garage;            // TaxiStation Garage
        
        #endregion // FIELDS
               

        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// TaxiStation Garage
        /// </summary>
        public GarageModel Garage { get => _garage; }

        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public TaxiStationModel() : this(null) { }
        public TaxiStationModel(List<object> vehicles)
        {
            if (vehicles == null)
            {
                this._garage = new GarageModel();
                AutoShopModel autoShop = new AutoShopModel();
                //autoShop.DisplayCarForSale();
                for (int i = 0; i < 3; i++)                         // добавим автомобили в гараж
                {
                    this._garage.AddVehicle(BuyCar(autoShop));
                }
            }
            else
            {
                this._garage = new GarageModel(vehicles);
            }
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Sort Cars
        /// </summary>
        internal string GetSortedCars()
        {
            var lst = Garage.Vehicles.OrderBy(x => ((VehicleBase)x).Engine.Model.FuelConsumptionTown);
            StringBuilder str = new StringBuilder();
            str.Append("Транспортные средства, отсортированные по расходу топлива:\n");
            foreach (var item in lst)
            {
                var vehicle = item as VehicleBase;
                str.Append(String.Format("- {0,13};   Расход:{1,3} л/100 км;\n",
                    vehicle.Brand.Name, vehicle.Engine.Model.FuelConsumptionTown));
            }
            return str.ToString();
        }


        /// <summary>
        /// Total vehicle cost 
        /// </summary>
        /// <returns></returns>
        internal int GetVehiclesTotalCost()
        {
            return Garage.Vehicles.Sum(x => ((VehicleBase)x).CurrentPrice);
        }

        /// <summary>
        /// Find vehicles by speed
        /// </summary>
        /// <param name="from">from speed</param>
        /// <param name="to">to speed</param>
        /// <returns>string result</returns>
        internal string FindVehiclesBySpeed(int from, int to)
        {
            // Здесь проверка входных данных на валидность
            // ...

            var lst = Garage.Vehicles.Where(x => ((VehicleBase)x).ForwardMaxSpeed >= from && ((VehicleBase)x).ForwardMaxSpeed <= to)
                                     .OrderBy(x => ((VehicleBase)x).ForwardMaxSpeed);
            StringBuilder str = new StringBuilder();
            str.Append("Транспортные средства, удовлетворяющие условию:\n");

            if (lst == null || lst.Count() < 1)
            {
                str.Append("- нет");
            }
            else
            {
                foreach (var item in lst)
                {
                    var vehicle = item as VehicleBase;
                    str.Append(String.Format("- {0,13};    Скорость: {1,3} км/ч;\n",
                        vehicle.Brand.Name, vehicle.ForwardMaxSpeed));
                }

            }
            return str.ToString();
        }



        /// <summary>
        /// Buy Car (temporary solution)
        /// </summary>
        /// <returns>null or new Car()</returns>
        internal Car BuyCar(AutoShopModel autoShop)
        {
            return autoShop.SaleCar();
        }


        /// <summary>
        /// View vehicle in the Garage grupping by its type
        /// </summary>
        /// <returns></returns>
        public string ViewGarageAutopark()
        {
            var vehicleGroups = _garage.Vehicles.GroupBy(v => ((VehicleBase)v).VehicleType); 
            StringBuilder strVehicles = new StringBuilder(); 
            foreach (var item in vehicleGroups)
            {
                strVehicles.Append(GetVehicleType(item.Key) + ":\n");
                strVehicles.Append(GetVehiclesInfo(item));
            }
            return strVehicles.ToString();
        }


        /// <summary>
        /// Get Vehicle Information
        /// </summary>
        /// <param name="value">ICollection vehicle list</param>
        /// <returns>Formated string (general each vehicle information)</returns>
        private string GetVehiclesInfo(object value)
        {
            StringBuilder strVehicleInfo = new StringBuilder();
            var vehicles = value as IEnumerable;
            if (vehicles != null)
            {
                foreach (var item in vehicles)
                {
                    if (item is VehicleBase)
                    {
                        var vehicle = item as VehicleBase;
                        strVehicleInfo.Append(String.Format("- Модель: {0,13};    Цена: {1,7:#,#} BYN;    Скорость: {2,3} км/ч;    Расход:{3,3} л/100 км;\n",
                            vehicle.Brand.Name, vehicle.CurrentPrice, vehicle.ForwardMaxSpeed, vehicle.Engine.Model.FuelConsumptionTown));
                    }
                }
            }
            return strVehicleInfo.ToString();
        }


        /// <summary>
        /// Get vehicle type from Garage vehicle lists
        /// </summary>
        /// <param name="key">String (dictionary key from Garage list)</param>
        /// <returns></returns>
        private string GetVehicleType(string key)
        {
            switch (key)
            {
                case "Car":
                    return "Легковые автомобили";
                default:
                    return "Прочие транспортные средства";
            }
        }



        #endregion // METHODS


    }
}
