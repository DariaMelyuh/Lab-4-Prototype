using Library;
using Lab_1_AbstractFactory;
namespace Lab_4_Prototype
{
    internal class MazeFactoryWithBoombPrototype : MazeFactoryPrototype
    {
        protected MazeFactoryWithBoombPrototype()
        : base(new Maze(), new WallWithBoomb(), new RoomWithBoomb(), new Door())
        {}
    }
}
