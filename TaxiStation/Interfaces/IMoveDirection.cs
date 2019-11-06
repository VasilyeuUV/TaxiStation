using TaxiStation.Enums;

namespace TaxiStation.Interfaces
{

    /// <summary>
    /// Direction of movement (up, down, left, right, forward, backward)
    /// </summary>
    public interface IMoveDirection :IMoveable
    {

        /// <summary>
        /// Direction of movement (up, down, left, right, forward, backward)
        /// </summary>
        EnumMoveDirection MoveDirection { get; }


    }
}
