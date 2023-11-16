using Library;
namespace Lab_1_AbstractFactory
{
    public class MazeWithBoombFactory : MazeFactory
    {
        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            return new RoomWithBoomb(number);
        }

        public override Wall CreateWall()
        {
            return new WallWithBoomb();
        }
    }
}
