using Machinery.Interfaces;
using Machinery.MachinerySystems;
using System;

namespace Machinery.Vehicles
{
    public abstract class VehicleBase : ISelfPropelled, IPriceable
    {

        #region FIELDS
        //##################################################################################################################




        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

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

            this.ForwardMaxSpeed = SetMaxSpeedRND();          // 
        }







        #endregion // CTOR



        #region METHODS
        //##################################################################################################################


        private int SetMaxSpeedRND()
        {
            Random rnd = new Random();
            return rnd.Next(100, 280);     // Получить случайное число (в диапазоне от 100 до 280)
        }



        #endregion // METHODS

    }
}
