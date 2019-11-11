﻿using TaxiStation.Interfaces;
using TaxiStation.MachinerySystems;

namespace TaxiStation.Vehicles
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
        public Brand Brand { get; set; }

        /// <summary>
        /// Vehicle Engine
        /// </summary>
        public Mover Engine { get; set; }


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

            this.ForwardMaxSpeed = SetFuelConsumtionRND();          // 
        }







        #endregion // CTOR



        #region METHODS
        //##################################################################################################################


        private int SetFuelConsumtionRND()
        {
            //Random rnd = new Random();
            //return rnd.Next(3, 15);     // Получить случайное число (в диапазоне от 3 до 15)
            return 0;
        }


        private int SetMaxSpeedRND()
        {
            //Random rnd = new Random();
            //return rnd.Next(100, 280);     // Получить случайное число (в диапазоне от 100 до 280)
            return 0;
        }


        #endregion // METHODS

    }
}