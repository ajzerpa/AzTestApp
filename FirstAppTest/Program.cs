using System;

namespace FirstAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World AZ!!!");
            var entry = Console.ReadLine();
            if (!string.IsNullOrEmpty(entry))
                entry = "Hello again 24/10";

            entry += "Master branch";
            //Master commit
            Console.WriteLine("GOT 11 season");
            Console.WriteLine("Breaking Bad");
            Console.WriteLine("the Walking Dead");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
