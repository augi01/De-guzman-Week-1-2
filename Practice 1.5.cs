using System;

class Program
{
    static void Main()
    {

        // Practice 01.5
      
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter choice (A for Area, P for Perimeter, X to Exit): ");
        char choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        switch (choice)
        {
            case 'A':
                double area = 3.146 * r * r;
                Console.WriteLine("Area of circle: " + area);
                break;

            case 'P':
                double peri = 2 * 3.146 * r;
                Console.WriteLine("Perimeter of circle: " + peri);
                break;

            case 'X':
                Console.WriteLine("Exiting...");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
