namespace Xolta.TriangleClassification.Models
{
    public class ScaleneTriangle(int SideA, int SideB, int SideC) : Triangle(SideA, SideB, SideC)
    {
        public override string ToString() => "Scalene";
    }
}