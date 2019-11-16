using Machinery.Interfaces;
using Machinery.MachinerySystems;
using System;

namespace Machinery.Vehicles
{

    /// <summary>
    /// Base class for all selfpropelled vehicles
    /// </summary>
    public abstract class VehicleBase : ISelfPropelled, IPriceable
    {

        #region PROPERTIES
        //##################################################################################################################

        public string VehicleType { get; protected set; }

        /// <summary>
        /// Vehicle brand
        /// </summary>
        public Brand Brand { get; internal set; }


        /// <summary>
        /// Vehicle Model
        /// </summary>
        public Mover Engine { get; internal set; }


        /// <summary>
        /// 
        /// </summary>
        public int ForwardMaxSpeed { get; private set; }



        /// <summary>
        /// Vehicle Price
        /// </summary>
        public int CurrentPrice { get; set; }


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public VehicleBase()
        {
            this.ForwardMaxSpeed = SetMaxSpeedRND(Production.rnd); 
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Set vehicle max speed 
        /// /// </summary>
        /// <returns>integer</returns>
        private int SetMaxSpeedRND(Random rnd)
        {
            return rnd.Next(100, 280);     // Получить случайное число (в диапазоне от 100 до 280)
        }



        #endregion // METHODS

    }
}
