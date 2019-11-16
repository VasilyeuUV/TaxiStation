using Machinery;
using Machinery.Vehicles;
using System;

namespace Shop.Models
{
    internal class CarForSaleModel
    {

        #region PROPERTIES
        //##################################################################################################################

        public int CurrentPrice { get; private set; }

        public Car Car { get; private set; }

        #endregion // PROPERTIES




        #region CTOR
        //##################################################################################################################

        public CarForSaleModel(Random rnd)
        {
            this.Car = Production.NewCar();
            this.CurrentPrice = SetPriceRND(rnd);
        }

        #endregion // CTOR





        #region METHODS
        //##################################################################################################################


        private int SetPriceRND(Random rnd)
        {
            return rnd.Next(20_000, 100_000);
        }

        #endregion // METHODS

    }
}
