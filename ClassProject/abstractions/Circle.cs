
namespace ClassProject
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public int Diameter { get; set; }

        public override double GetArea()
        {
            return Diameter * System.Math.PI;
        }
    }
}
