namespace Xolta.TriangleClassification.Models
{
    public class Triangle(int SideA, int SideB, int SideC)
    {
        public int SideA { get; set; } = SideA;
        public int SideB { get; set; } = SideB;
        public int SideC { get; set; } = SideC;

        public override string ToString() => "Triangle";
    }
}