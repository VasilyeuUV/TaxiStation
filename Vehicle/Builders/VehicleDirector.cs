using Machinery.Builders;

namespace Machinery.Builders
{
    public class VehicleDirector
    {


        #region FIELDS
        //##################################################################################################################

        private IVehicleBuilder _vehicleBuilder;

        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// VehicleBuilder Interface object
        /// </summary>
        internal IVehicleBuilder VehicleBuilder { set => _vehicleBuilder = value; }

        #endregion // PROPERTIES


        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Byild Car
        /// </summary>
        public void BuildCar()
        {
            this._vehicleBuilder.SetBrand();
            this._vehicleBuilder.SetEngine();
        }



        ///// <summary>
        ///// Build truck
        ///// </summary>
        //public void BuildGarageTrackCar()
        //{

        //}


        #endregion // METHODS


    }
}
