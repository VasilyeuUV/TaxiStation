using TaxiStation.Enums;

namespace TaxiStation.Elements.FuelSystem
{
    public abstract class FuelSystemBase
    {

        #region Fields
        //##################################################################################################################

        #endregion // Fields



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Engine fuel type
        /// </summary>
        public EnumFuelType FuelType { get; protected set; }

        /// <summary>
        /// Fuel tank or battery capacity
        /// </summary>
        public int FuelCapacity { get; protected set; }


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        #endregion // METHODS

    }
}

