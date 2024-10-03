using System;
namespace uppgift_2._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elin hur långt håppade du i meter?");
            string elin = Console.ReadLine();
            double Elin = double.Parse(elin);
            Console.WriteLine("Alma hur långt hoppade du i meter?");
            string alma = Console.ReadLine();
            double Alma = double.Parse(alma);
            double skilnad = Elin-Alma;
            Console.WriteLine("Elin hoppade" +skilnad+ "meter längre än Alma");
        }
    }
}