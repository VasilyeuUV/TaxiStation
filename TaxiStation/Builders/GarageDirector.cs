namespace TaxiStation.Builders
{

    /// <summary>
    /// Variants for creating a Garage
    /// </summary>
    public class GarageDirector
    {

        #region FIELDS
        //##################################################################################################################

        private IGarageBuilder _garageBuilder;

        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// GarageBuilder Interface object
        /// </summary>
        internal IGarageBuilder GarageBuilder { set => _garageBuilder = value; }

        #endregion // PROPERTIES


        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Garage with cars only
        /// </summary>
        public void BuildGarageCar()
        {
            this._garageBuilder.BuildCarList();
        }



        ///// <summary>
        ///// Garage with cars and trucks
        ///// </summary>
        //public void BuildGarageTrackCar()
        //{
        //    this._garageBuilder.BuildCarList();
        //    this._garageBuilder.BuildTruckList();
        //}


        #endregion // METHODS

    }
}
