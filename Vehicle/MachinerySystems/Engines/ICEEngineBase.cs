using Machinery.Interfaces;
using System;

namespace Machinery.MachinerySystems.Engines
{
    /// <summary>
    /// Internal combustion engine abstract class
    /// </summary>
    public abstract class ICEEngineBase : IFuelConsumptionVehicle
    {

        #region Fields
        //##################################################################################################################

        #endregion // Fields



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// engine type
        /// </summary>
        public string Name { get; protected set; }


        /// <summary>
        /// Fuel consumption in the city
        /// </summary>
        public abstract int FuelConsumptionTown { get; protected set; }







        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        protected int SetFuelConsumtionRND()
        {
            Random rnd = new Random();
            return rnd.Next(3, 15);     //Получить случайное число (в диапазоне от 3 до 15)
        }




        #endregion // METHODS

    }
}
