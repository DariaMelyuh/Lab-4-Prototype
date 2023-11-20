namespace Library
{
    public class Door : IMapSite
    {
        private Room _room1;
        private Room _room2;

        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }
        
        public Door() { }

        public Door(Room room1, Room room2)
        {

            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Ошибка   null ");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Ошибка null");
            }
            this._room1 = room1;
            this._room2 = room2;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Дверь открыта");
        }

        public Room OtherSideFrom(Room room)
        {
            if (room.Number == _room1.Number)
            {
                return _room2;
            }
            else if (room.Number == _room2.Number)
            {
                return _room1;
            }
            else
            {
                throw new Exception("Куда пошел");
            }
        }

        public virtual IMapSite Clone()
        {
            Room cloneRoom1 = _room1.Clone() as Room;
            Room cloneRoom2 = _room2.Clone() as Room;
            return new Door(cloneRoom1, cloneRoom2);
        }
    }
}