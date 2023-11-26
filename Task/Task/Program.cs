class Program
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("Invalid input for side 1.");
            return;
        }

        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input2))
        {
            Console.WriteLine("Invalid input for side 2.");
            return;
        }

        double side1, side2;

        if (!double.TryParse(input1, out side1))
        {
            Console.WriteLine("Invalid input for side 1. Please enter a valid number.");
            return;
        }

        if (!double.TryParse(input2, out side2))
        {
            Console.WriteLine("Invalid input for side 2. Please enter a valid number.");
            return;
        }

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter}");
        Console.WriteLine($"Area of the rectangle: {rectangle.Area}");
    }
}
