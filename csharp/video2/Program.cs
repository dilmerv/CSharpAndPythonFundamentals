using System;

namespace video2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Video 2 Lesson");

            // Variable Types

            // int
            // string
            // float

            Console.WriteLine("---------------");
            int age = 25;
            Console.WriteLine(age);

            string name = "John Doe";
            Console.WriteLine(name);

            float weight = 12.5F;
            Console.WriteLine(weight);

            Console.WriteLine("Formatted:");

            Console.WriteLine($"Name: {name} Age: {age} Weight: {weight}");
        }
    }
}
