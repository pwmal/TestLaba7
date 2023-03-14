using TestLaba7.Classes;

namespace TestLaba7.interfaces
{
    public interface ITriangleProvider
    {
        Triangle GetById(int id);
        List<Triangle> GetAll();
        void Save(Triangle triangle);
    }
}
