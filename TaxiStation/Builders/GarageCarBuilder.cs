using System.Collections.Generic;
using TaxiStation.Models;
using TaxiStation.Vehicles;

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
        /// 
        /// </summary>
        /// <returns>new Garage object</returns>
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
            List<Car> carList = new List<Car>()
            {
                new Car(),
                new Car(),
                new Car()
            };
            this._garage.Add(carList);
        }

        #endregion // METHODS

    }
}
