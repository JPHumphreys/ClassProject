
namespace ClassProject
{
    public class Triangle : Shape
    {
        public int Height { get; set; }
        public int Base { get; set; }

        public override double GetArea()
        {
            return Height * (Base / 2);
        }
    }
}
