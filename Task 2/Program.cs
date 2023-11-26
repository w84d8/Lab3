class Program
{
    static void Main()
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 1, "B");
        Point point3 = new Point(1, 1, "C");
        Point point4 = new Point(1, 0, "D");

        Figure rectangle = new Figure(point1, point2, point3, point4);

        rectangle.CalculatePerimeter();
    }
}