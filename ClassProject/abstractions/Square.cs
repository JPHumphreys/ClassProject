
namespace ClassProject
{
    public class Square : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetPermimiter()
        {
            return (Width * 2) + (Height * 2);
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
