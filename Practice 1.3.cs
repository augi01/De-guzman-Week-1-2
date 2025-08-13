using System;

class Program
{
    static void Main()
    {
    
    \\Practice 01.3
    
        int person1 = 30;
        double person2 = 52000;

        if (person1 >= 25 && person1 <= 35 && person2 > 50000)
        {
            Console.WriteLine("Young Professional");
        }
        else if (person1 >= 36 && person1 <= 55 && person2 > 70000)
        {
            Console.WriteLine("Middle-Aged Professional");
        }
        else if (person1 >= 56 && person2 < 30000)
        {
            Console.WriteLine("Senior Citizen");
        }
        else
        {
            Console.WriteLine("Other");
        }
    }
}
