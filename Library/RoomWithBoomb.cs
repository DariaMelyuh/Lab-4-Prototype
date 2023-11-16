namespace Library
{
    public class RoomWithBoomb : Room
    {
        private static Random _rnd = new Random();
        public RoomWithBoomb(int number) : base(number)
        {}

        public RoomWithBoomb()
        {}

        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Бомба взорвалась");
                sides.OfType<WallWithBoomb>().ToList().ForEach(wall => wall.Enter());
            }
        }

        public override Room Clone()
        {
            return (RoomWithBoomb)this.MemberwiseClone();
        }
    }
}