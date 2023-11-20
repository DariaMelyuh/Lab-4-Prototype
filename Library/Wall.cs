namespace Library
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы врезались в стену");
        }

        public virtual IMapSite Clone()
        {
            return new Wall();
        }
    }
}
