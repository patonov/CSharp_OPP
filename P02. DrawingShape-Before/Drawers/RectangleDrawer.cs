using System;
using System.Collections.Generic;
using System.Text;

namespace P02._DrawingShape_Before.Drawers
{
    using Contracts;

    public class RectangleDrawer : IDrawable
    {
        public void Draw(IShape shape)
        {
            Console.WriteLine("I am drawing a rectangle.");
        }

        public bool IsMatch(IShape shape)
        {
            return shape is Rectangle;
        }
    }
}
