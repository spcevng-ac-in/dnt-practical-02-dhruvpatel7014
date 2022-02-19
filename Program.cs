using System;

namespace practicle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRANSPORTATION SYSTEM");
            Console.WriteLine("Enter the Distance:");
           int dist=Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter the weight of goods in Kg:");
            int weight = Convert.ToInt32(Console.ReadLine());
            int cost;
            if(dist<100)
            {
                cost = 50 *weight;

            }
            else if(dist<200)
            {
                cost = 65 * weight;
            }
            else if (dist < 300)
            {
                cost = 90 * weight;
            }
            else
            {
                cost = 120 * weight;
            }
            Console.WriteLine($"Total cost of goods is{cost}");
            Console.ReadLine();

        }
    }
}
