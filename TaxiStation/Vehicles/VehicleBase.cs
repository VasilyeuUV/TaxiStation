using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Enums;
using TaxiStation.Interfaces;
using TaxiStation.MachinerySystems.Brand;

namespace TaxiStation.Vehicles
{
    public abstract class VehicleBase : ISelfPropelled
    {

        #region FIELDS
        //##################################################################################################################




        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Vehicle brand
        /// </summary>
        public Brand Brand { get; protected set; }




        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public VehicleBase()
        {

        }







        #endregion // CTOR



        #region METHODS
        //##################################################################################################################


        private int SetFuelConsumtionRND()
        {
            Random rnd = new Random();
            return rnd.Next(3, 15);     //Получить случайное число (в диапазоне от 3 до 15)
        }




        #endregion // METHODS

    }
}
