
namespace FigureLibrary
{
    public class Triangle : Figure
    {

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }


        public Triangle(string typeName, double sideA , double sideB, double sideC) : base(typeName)
        {
            if (CorrectData(sideA,sideB,sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными");
            }
        }

        public bool IsRightTriangle() 
        {
            return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideC, 2) == Math.Pow(SideB, 2) + Math.Pow(SideA, 2);
         
        
        }

        private bool CorrectData(double sideA, double sideB, double sideC)
        {
            return sideA > 0 && sideB > 0 && sideC > 0;
        }



        public override double CalculateSquare()
        {
            var p = (SideA + SideB + SideC) / 2;
            var square = Math.Round( Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)),1);
            return square;
        }
    }
}
