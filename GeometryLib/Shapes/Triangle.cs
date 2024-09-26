using GeometryLib.Interfaces;

namespace GeometryLib.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (!IsValidTriangle())
                throw new ArgumentException("Невозможно создать треугольник с такими сторонами.");
        }

        private bool IsValidTriangle()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        public double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightAngled() =>
                    (SideA * SideA + SideB * SideB == SideC * SideC) ||
                    (SideA * SideA + SideC * SideC == SideB * SideB) ||
                    (SideC * SideC + SideB * SideB == SideA * SideA);
    }
}

