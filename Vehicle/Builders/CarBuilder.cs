using Machinery.Vehicles;

namespace Machinery.Builders
{
    class CarBuilder : IVehicleBuilder
    {


        #region FIELDS
        //##################################################################################################################

        private Car _car = new Car();

        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################




        #endregion // PROPERTIES




        #region CTOR
        //##################################################################################################################

        public CarBuilder()
        {
            this.Reset();                   // Clear this class and create new class object
        }


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Reset this class
        /// </summary>
        private void Reset()
        {
            this._car = new Car();
        }


        /// <summary>
        /// Return new Car
        /// </summary>
        /// <returns>Car (new Car object)</returns>
        public Car GetCar()
        {
            Car result = this._car;
            this.Reset();
            return result;
        }
               

        /// <summary>
        /// Set car brand
        /// </summary>
        public void SetBrand()
        {
            this._car.Brand = new MachinerySystems.Brand();
        }

        public void SetEngine()
        {
            this._car.Engine = new MachinerySystems.Mover();
        }


        #endregion // METHODS





    }
}
