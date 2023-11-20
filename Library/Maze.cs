namespace Library
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNo(int number)
        {
            return _rooms.Single(room => room.Number == number);
        }

        public Maze Clone()
        {
            Maze cloneMaze = new Maze();

            foreach (var room in _rooms)
            {
                cloneMaze.AddRoom(room.Clone());
            }
            return cloneMaze;
        }
    }
}