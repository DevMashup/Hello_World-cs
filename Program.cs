using System;

namespace practice {
    class HelloWorld {
        static void Main(string[] args) {
            Console.WriteLine("Pleas enter your name");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");        
        }
    }
}
