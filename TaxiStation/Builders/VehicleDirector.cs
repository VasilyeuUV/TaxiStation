using TaxiStation.Interfaces;

namespace TaxiStation.Models
{
    class VehicleDirector
    {

        #region FIELDS
        //##################################################################################################################

        private IVehicleListBuilder _vehicleListBuilder;





        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        internal IVehicleListBuilder VehicleListBuilder { set => _vehicleListBuilder = value; }

        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        public void BuildCarList()
        {
            this._vehicleListBuilder.BuildCarList();
        }


        #endregion // METHODS

    }
}
