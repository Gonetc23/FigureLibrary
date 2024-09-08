
namespace FigureLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(string typeName, double radius) : base(typeName)
        {
            if (CheckRadius(radius))
                Radius = radius;
            else
                throw new ArgumentException("Некорректный радиус");
        }


        public override double CalculateSquare()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }

        private bool CheckRadius(double radius)
        {
            return radius > 0;
        }
    }
}
