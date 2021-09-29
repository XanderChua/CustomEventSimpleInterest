using System;

namespace CustomEventSimpleInterest
{
    class Program
    {
        class SimpleInterestCal // publisher
        {           
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Calculate Simple Interest");
                    Console.WriteLine("Input interest:");
                    int inputPrincipal = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input interest:");
                    int inputInterest = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Input time in months:");
                    int inputimeMonths = Int32.Parse(Console.ReadLine());
                    Publisher p = new Publisher();
                    p.modifiedEvent += P_modifiedEvent;//subscribe to event
                    p.CalcSimpleInterest(inputPrincipal, inputInterest, inputimeMonths);
                }
                private static void P_modifiedEvent(object sender, IntEventArgs e)
                {
                    Console.WriteLine("Your simple interest is: " + e.cal);
                }
            }
        }
    }

}
}
