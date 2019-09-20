using System;

namespace vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] five_string_array = new string[5];

            for (int i = 0; i < 5; i++){
                Console.WriteLine("Skriv in ett namn: ");

                string input = Console.ReadLine();

                five_string_array[i] = input;
            }

            for (int i = 0; i < 5; i++){
                string oneInt = five_string_array[i];
            }

            Console.WriteLine("Du skrev namnen:");

            for (int i = 0; i < 5; i++){
                Console.Write(" " + five_string_array[i]);
            }

        }
    }
}
