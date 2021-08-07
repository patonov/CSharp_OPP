namespace P02._DrawingShape_Before.Contracts
{
    public interface IDrawable
    {
        void Draw(IShape shape);

        bool IsMatch(IShape shape); 
    }
}
