using Machinery.Vehicles;
using Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TaxiStation.Builders;

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

        public TaxiStationModel()
        {

            // Create Garage
            //var director = new GarageDirector();
            //var builder = new GarageCarBuilder();
            //director.GarageBuilder = builder;
            //director.BuildGarageCar();
            //this._garage = builder.GetGarage();
            //this._garage.Add();


            this._garage = new GarageModel();
            // добавим автомобили в гараж
            for (int i = 0; i < 3; i++)
            {
                var newCar = BuyCar();
                if (newCar != null)
                {
                    this._garage.AddVehicle(newCar);
                }
            }
        }




        private Car BuyCar()
        {
            AutoShopModel autoShop = new AutoShopModel();
            return autoShop.SaleCar();
        }




        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        public string ViewGarageAutopark()
        {
            StringBuilder strVehicles = new StringBuilder();

            foreach (var item in Garage.Vehicles)
            {
                var dict = (KeyValuePair<string, ICollection>)item;
                strVehicles.Append(GetVehicleType(dict.Key) + ":\n");
                strVehicles.Append(GetVehiclesInfo(dict.Value));
            }
            return strVehicles.ToString();
        }

        private string GetVehiclesInfo(ICollection value)
        {
            StringBuilder strVehicleInfo = new StringBuilder();
            foreach (var item in value)
            {
                if (item is VehicleBase)
                {
                    var vehicle = item as VehicleBase;
                    strVehicleInfo.Append(String.Format(CultureInfo.InvariantCulture, 
                        "- Модель: {0,13};    Цена: {1,7:#,#} BYN;    Скорость: {2,3} км/ч;    Расход:{3,3} л/100 км;\n", 
                        vehicle.Brand.Name, vehicle.CurrentPrice, vehicle.ForwardMaxSpeed, vehicle.Engine));
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
