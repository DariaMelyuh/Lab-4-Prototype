using Library;
using Lab_1_AbstractFactory;
namespace Lab_4_Prototype
{
    internal class MazeFactoryWithTrapPrototype : MazeFactoryPrototype
    {
         protected MazeFactoryWithTrapPrototype()
            : base(new Maze(), new Wall(), new RoomWithTrap(), new DoorWithTrap())
        {}
    }
}
