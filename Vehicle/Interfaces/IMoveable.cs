namespace TaxiStation.Interfaces
{
    /// <summary>
    /// The main speed parameters of the object to move (up, down, left, right, forward, backward)
    /// </summary>
    public interface IMoveable
    {
        ///// <summary>
        ///// Сurrent object speed
        ///// </summary>
        //int CurrentSpeed { get; }

        /// <summary>
        /// The maximum speed of the object forward (>0)
        /// </summary>
        int ForwardMaxSpeed { get; }

        ///// <summary>
        ///// The maximum speed of the object backward (negative meaning)
        ///// </summary>
        //int BackwardMaxSpeed { get; }



    }
}
