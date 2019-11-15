using Machinery.Builders;
using Machinery.Vehicles;
using System.Collections.Generic;
using TaxiStation.Models;

namespace TaxiStation.Builders
{

    /// <summary>
    /// Build a Car Garage
    /// </summary>
    public class GarageCarBuilder : IGarageBuilder
    {

        #region FIELDS
        //##################################################################################################################

        private GarageModel _garage = new GarageModel();        // final product


        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################


        #endregion // PROPERTIES



        #region CTOR
        //##################################################################################################################

        public GarageCarBuilder()
        {
            this.Reset();       // the new builder instance must contain an empty product object
        }




        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Instal empty product object
        /// </summary>
        private void Reset()
        {
            this._garage = new GarageModel();
        } 


        /// <summary>
        /// Return new Garage
        /// </summary>
        /// <returns>GarageModel (new Garage object)</returns>
        public GarageModel GetGarage()
        {
            GarageModel result = this._garage;
            this.Reset();
            return result;
        }


        /// <summary>
        /// Build Car List
        /// </summary>
        public void BuildCarList()
        {
            //var director = new VehicleDirector();
            //var builder = new CarBuilder();
            //director.VehicleBuilder = builder;
            //director.BuildCar();
            //builder.GetCar()

            //List<Car> carList = new List<Car>()
            //{
            //   ,
            //    builder.GetCar(),
            //    builder.GetCar()
            //};
            //this._garage.Add(typeof(Car).Name, carList);
        }

        #endregion // METHODS

    }
}
