namespace Library
{
    public class WallWithBoomb : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Стена взорвана");
        }

        public override Wall Clone()
        {
            return new WallWithBoomb();
        }
    }
}
