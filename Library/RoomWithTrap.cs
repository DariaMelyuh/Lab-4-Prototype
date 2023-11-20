namespace Library
{
    public class RoomWithTrap : Room
    {
        private static Random _rnd = new Random();
        public RoomWithTrap(int number) : base(number)
        { }

        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Сработала ловушка, дверь закрыта");
                sides.OfType<DoorWithTrap>().ToList().ForEach(door => door.IsOpen = false);
            }
        }

        public RoomWithTrap()
        { }

        public override Room Clone()
        {
            return new RoomWithTrap(Number);
        }
    }
}