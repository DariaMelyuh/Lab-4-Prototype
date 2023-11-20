namespace Library
{
    public class WallWithBoomb : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Стена взорвана");
        }

        public override IMapSite Clone()
        {
            return new WallWithBoomb();
        }
    }
}
