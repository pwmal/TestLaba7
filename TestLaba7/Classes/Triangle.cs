namespace TestLaba7.Classes
{
    public class Triangle
    {
        public int id;
        public double a;
        public double b;
        public double c;
        public double sq;
        public string type;

        public Triangle(int ID, double A, double B, double C, double Sq, string Type)
        {
            id = ID;
            a = A;
            b = B;
            c = C;
            sq = Sq;
            type = Type;
        }

        public Triangle()
        {

        }
    }
}
