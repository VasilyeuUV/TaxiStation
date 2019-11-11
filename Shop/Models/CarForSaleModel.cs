﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStation.Vehicles;

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

        public CarForSaleModel()
        {
            this.Car = new Car();
            this.CurrentPrice = SetPriceRND();
        }

        #endregion // CTOR





        #region METHODS
        //##################################################################################################################


        private int SetPriceRND()
        {
            Random rnd = new Random();
            return rnd.Next(20_000, 160_000);
        }

        #endregion // METHODS

    }
}
