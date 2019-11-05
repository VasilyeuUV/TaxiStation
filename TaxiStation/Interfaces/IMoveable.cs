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
        /// Maximum object speed
        /// </summary>
        int MaxSpeed { get; }
    
    }
}
