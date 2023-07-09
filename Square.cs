namespace Shape
{
    public class Square : IShape
    {
        private double _a;
        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                if (_a <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0");
                }
                _a = value;
            }
        }

        public Square(int a)
        {
            _a = a;
        }
        public double CalculateArea()
        {
            return a * a;
        }
        public double CalculatePerimeter()
        {
            return a * 4;
        }
    }
}