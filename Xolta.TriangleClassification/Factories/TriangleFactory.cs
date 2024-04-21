using Xolta.TriangleClassification.Models;

namespace Xolta.TriangleClassification.Factories
{
    public class TriangleFactory : ITriangleFactory
    {
        public Triangle Create(int sideA, int sideB, int sideC)
        {
            if (sideA == sideB && sideB == sideC)
            {
                return new EquilateralTriangle(sideA, sideB, sideC);
            }

            if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                return new IsoscelesTriangle(sideA, sideB, sideC);
            }

            return new ScaleneTriangle(sideA, sideB, sideC);
        }
    }
}