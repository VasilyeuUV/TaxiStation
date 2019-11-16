using Machinery.Vehicles;
using Shop.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TaxiStation.Models
{
    public class GarageModel
    {

        #region FIELDS
        //##################################################################################################################

        private List<object> _vehicles;

        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        //internal Dictionary<string, ICollection> Vehicles { get => _vehicles; }

        internal List<object> Vehicles { get => _vehicles; }



        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public GarageModel()
        {
            this._vehicles = new List<object>();
        }
        public GarageModel(List<object> vehicles)
        {
            this._vehicles = vehicles;
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Add new Car to Garage 
        /// </summary>
        /// <param name="newCar">Type: Car</param>
        internal void AddVehicle(Car newCar)
        {
            if (newCar != null)
            {
                this._vehicles.Add(newCar);
            }  
        }






        ///// <summary>
        ///// Add new vehicles to Garage 
        ///// </summary>
        ///// <param name="car"></param>
        //internal void AddVehicle<T>(T car) where T : VehicleBase
        //{


        //Type V = car.GetType();
        //if (_vehicles.ContainsKey(V.Name))
        //{
        //    dynamic list = _vehicles[V.Name];
        //    list.Add(car);
        //    ICollection collection = list;
        //    _vehicles[V.Name] = list;
        //}
        //else
        //{
        //    List<T> lst = new List<T>();
        //    lst.Add(car);
        //    ICollection collection = lst;
        //    this.Vehicles.Add(V.Name, lst);
        //}
        //}


        #endregion // METHODS





    }
}