namespace Machinery.MachinerySystems.Engines
{
    internal class DieselEngine : ICEEngineBase
    {


        #region FIELDS
        //##################################################################################################################




        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Fuel consumption in the city
        /// </summary>
        public override int FuelConsumptionTown { get; protected set; }



        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        public DieselEngine()
        {
            this.Name = "Disel Engine";
            this.FuelConsumptionTown = SetFuelConsumtionRND();
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################






        #endregion // METHODS

    }
}
