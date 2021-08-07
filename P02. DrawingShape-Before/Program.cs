using System;

namespace P02._DrawingShape_Before
{
    using Drawers;
    using Contracts;

    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager dm = new DrawingManager();

            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            dm.Draw(rectangle);
            dm.Draw(circle);
        }
    }
}
