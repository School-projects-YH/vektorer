using System;

namespace vektorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] five_int_array = new int[5];

            for (int i = 0; i < 5; i++){
                Console.WriteLine("Skriv in ett tal: ");

                string input = Console.ReadLine();
                int tal_input = Convert.ToInt32(input);

                five_int_array[i] = tal_input;
            }
            
            int sum = 0;
            for (int i = 0; i < 5; i++){
                int foobar = five_int_array[i];
                sum += foobar;
            }

            Console.WriteLine("Din summa blev: {0}", sum);

        }
    }
}
