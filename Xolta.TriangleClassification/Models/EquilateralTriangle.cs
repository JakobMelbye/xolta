
namespace Xolta.TriangleClassification.Models
{
    public class EquilateralTriangle(int SideA, int SideB, int SideC) : Triangle(SideA, SideB, SideC)
    {
        public override string ToString() => "Equilateral";
    }
}