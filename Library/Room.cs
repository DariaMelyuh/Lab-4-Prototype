namespace Library
{
    public class Room : IMapSite
    {
        public int Number { get; set; }
        protected IMapSite[] sides = new IMapSite[4];
        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Номер комнаты не соответствует условию");
            }
            Number = number;
        }

        public Room()
        { }

        public IMapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            sides[(int)direction] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вошли в комнату");
        }

        public void Initialize(int roomNumber)
        {
            Number = roomNumber;
        }

        public virtual Room Clone()
        {
            Room cloneRoom = new Room(Number);

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] is Room roomSide)
                {
                    cloneRoom.sides[i] = roomSide.Clone();
                }
                else
                {
                    cloneRoom.sides[i] = sides[i];
                }
            }

            return cloneRoom;
        }
    }
}