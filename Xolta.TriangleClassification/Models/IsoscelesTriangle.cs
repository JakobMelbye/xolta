namespace Xolta.TriangleClassification.Models
{
    public class IsoscelesTriangle(int SideA, int SideB, int SideC) : Triangle(SideA, SideB, SideC)
    {
        public override string ToString() => "Isosceles";
    }
}