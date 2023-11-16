using Library;
namespace Lab_1_AbstractFactory
{
    public class MazeGame
    {
        public Maze Create(MazeFactory factory)
        {
            if (factory == null)
            {
                throw new Exception("Ошибка null");
            }
            Maze maze = factory.CreateMaze();
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);
            Door door = factory.CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.East, factory.CreateWall());
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            room2.SetSide(Direction.North, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.West, factory.CreateWall());

            return maze;

        }
    }
}
