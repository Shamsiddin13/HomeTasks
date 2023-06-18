namespace homeworks;

    public class Triangle
    {
        /// <summary>
        /// "Uchburchak" - shaklni yuzasini topib beradi! ->
        /// 
        /// Balandligi hamda Tayanch uzunligini kiriting: 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="baseLenght"></param>
        public Triangle(double height, double baseLength)
        {
            Height = height;
            BaseLength = baseLength;

        }

        public double Height;

        public double BaseLength;

        public double TriangleArea()
        {
           
            return BaseLength * Height / 2;
        }

    }

    public class Square
    {
        /// <summary>
        /// "Kvadrat" - shaklni yuzasini topib beradi! ->
        /// 
        /// Yon uzunligini kiriting:
        /// </summary>
        /// <param name="sideLength"></param>

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double SideLength;


        public double SquareArea()
        {
            return SideLength * SideLength;
        }

    }


    public class Rectangle
    {
        /// <summary>
        /// "Tog'ri" - To'rtburchakni yuzasini topib beradi! ->
        /// 
        /// Uzunligi hamda enini kiriting:
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length;

        public double Width;

        public double RectangleArea()
        {
            return Length * Width;
        }


    }

    public class Circle
    {
        /// <summary>
        /// "Doira" - shaklini yuzasini topib beradi! ->
        /// 
        /// Radiusini kiriting: 
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius;

        public double CircleArea()
        {
            double circlearea = Math.PI * Radius * Radius;
            return circlearea;
        }
    }

