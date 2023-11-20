using Library;
using Lab_1_AbstractFactory;
namespace Lab_4_Prototype
{
    internal class MazeFactoryPrototype : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Door _prototypeDoor;
        private Wall _prototypeWall;

        protected MazeFactoryPrototype(Maze maze, Wall wall, Room room, Door door)
        {
            if (maze == null)
            {
                throw new ArgumentNullException(nameof(maze), "Объект Maze не может быть равен null.");
            }

            if (wall == null)
            {
                throw new ArgumentNullException(nameof(wall), "Объект Wall не может быть равен null.");
            }

            if (room == null)
            {
                throw new ArgumentNullException(nameof(room), "Объект Room не может быть равен null.");
            }

            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Объект Door не может быть равен null.");
            }

            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }


        public MazeFactoryPrototype() : this(new Maze(), new Wall(), new Room(), new Door())
        {}

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }

        public override Room CreateRoom(int roomNumber)
        {
            
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            Room room = (Room)_prototypeRoom.Clone();
            room.Initialize(roomNumber);
            return room;
        }

        public override Wall CreateWall()
        {
            Wall wall = (Wall)_prototypeWall.Clone();
            return wall;
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комната не может быть null");
            }

            Door door = (Door)_prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}