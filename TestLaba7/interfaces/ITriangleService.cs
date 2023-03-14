namespace TestLaba7.interfaces
{
    public interface ITriangleService
    {
        bool IsValidTriangle(double a, double b, double c);
        string GetType(double a, double b, double c);
        double GetArea(double a, double b, double c);
    }
}
