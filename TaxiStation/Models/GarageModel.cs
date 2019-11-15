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
        
        private Dictionary<string, ICollection> _vehicles = new Dictionary<string, ICollection>();      // any type vehicles list
               
        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        internal Dictionary<string, ICollection> Vehicles { get => _vehicles; }

        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Add new vehicles to Garage 
        /// </summary>
        /// <param name="car"></param>
        internal void AddVehicle<T>(T car) where T : VehicleBase
        {
            Type V = car.GetType();
            if (_vehicles.ContainsKey(V.Name))
            {
                dynamic list = _vehicles[V.Name];
                list.Add(car);
                ICollection collection = list;
                _vehicles[V.Name] = list;
            }
            else
            {
                List<T> lst = new List<T>();
                lst.Add(car);
                ICollection collection = lst;
                this.Vehicles.Add(V.Name, lst);
            }
        }


        #endregion // METHODS





    }
}