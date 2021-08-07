using System;
using System.Collections.Generics;

namespace P02._DrawingShape_Before
{
    using Contracts;
    using Drawers;

    class DrawingManager : IDrawable
    {
        private List<IDrawable> drawers = new List<IDrawable>()
        {
            new CircleDrawer(),
            new RectangleDrawer()
        };
        
        public void Draw(IShape shape)
        {
            foreach (IDrawable drawer in drawers)
            {
                if (drawer.IsMatch(shape))
                {
                    drawer.Draw();
                }
            }
        }

        
    }
}
