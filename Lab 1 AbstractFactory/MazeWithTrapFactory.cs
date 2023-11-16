using Library;
namespace Lab_1_AbstractFactory
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            return new RoomWithTrap(number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Ошибка null ");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Ошибка null");
            }
            return new DoorWithTrap(room1, room2);
        }

    }
}
