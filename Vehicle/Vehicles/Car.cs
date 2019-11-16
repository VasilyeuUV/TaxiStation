using System;

namespace Machinery.Vehicles
{

    /// <summary>
    /// Civilian vehicle up to 3.5 tons
    /// </summary>
    public class Car : VehicleBase
    {

        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Car VIN
        /// </summary>
        public Guid VIN { get; private set; }

        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public Car()
        {
            this.VehicleType = this.GetType().Name;
            this.VIN = Guid.NewGuid();
        }

        #endregion // CTOR

    }
}
