using System;

namespace Machinery.Vehicles
{

    /// <summary>
    /// Civilian vehicle up to 3.5 tons
    /// </summary>
    public class Car : VehicleBase
    {

        #region FIELDS
        //##################################################################################################################

        #endregion // FIELDS



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

            this.VIN = Guid.NewGuid();
        }



        #endregion // CTOR



        #region METHODS
        //##################################################################################################################




        #endregion // METHODS



    }
}
