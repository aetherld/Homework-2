using System.Security.Cryptography.X509Certificates;

namespace Shape
{
    public class Circle : IShape
    {
        private double _r;
        public double r
        {
            get
            {
                return _r;
            }
            set
            {
                if (_r <= 0)
                {
                    throw new Exception("Радиус не может быть равен 0");
                }
                _r = value;
            }
        }
        
        public Circle(int r)
        {
            _r = r;
        }
        public double CalculateArea()
        {
            return 3.14 * r * r;
        }
        public double CalculatePerimeter()
        {
            return 2 * 3.14 * r;
        }
    }
}