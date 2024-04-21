using Xolta.TriangleClassification.Models;

namespace Xolta.TriangleClassification.Factories
{
    public interface ITriangleFactory
    {
        public Triangle Create(int sideA, int sideB, int sideC);
    }
}