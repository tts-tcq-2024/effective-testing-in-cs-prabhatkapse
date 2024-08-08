using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AlerterSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var Alerter = new Alerter(new NetworkAlert());

            Alerter.alertInCelcius(400.5f);
            Debug.Assert(Alerter.alertFailureCount == 1);

            Alerter.alertInCelcius(303.6f);
            Debug.Assert(Alerter.alertFailureCount == 2);

            Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }

    }
}
