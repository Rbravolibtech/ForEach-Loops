using System;

namespace ForEach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Uncomment the following code to see the iteration over characters in a string

            // var name = "Rock Cena";
            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            // FOREACH LOOP
            // foreach (var character in name)
            // {
            //     Console.WriteLine(character);
            // }
        }
    }
}
