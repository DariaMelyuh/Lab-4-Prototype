namespace Library
{
    public class DoorWithTrap : Door
    {

        internal bool IsOpen { get; set; }
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2)
        { }

        public DoorWithTrap()
        { }

        public override void Enter()
        {
            if (IsOpen)
            {
                base.Enter();
            }
            else
            {
                Console.WriteLine("Дверь закрылась, прохода нет");
            }
        }

        public override IMapSite Clone()
        {
            DoorWithTrap cloneDoor = base.Clone() as DoorWithTrap;
            cloneDoor.IsOpen = IsOpen;
            return cloneDoor;
        }
    }
}
