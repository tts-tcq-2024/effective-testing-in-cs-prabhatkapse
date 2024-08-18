using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AlerterSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Alerter alerter;

            alerter = new Alerter(new NetworkAlert());
            alerter.alertInCelcius(400.5f);
            Debug.Assert(alerter.alertFailureCount == 0);
            
            alerter = new Alerter(new NotOkNetworkAlert());
            alerter.alertInCelcius(400.5f);
            Debug.Assert(alerter.alertFailureCount == 1);

            var _MopNetworkAlert = new MopNetworkAlert();
            alerter = new Alerter(_MopNetworkAlert);
            float farenheit = 120.6f;
            float expectedcelcius = (farenheit - 32) * 5 / 9;
            alerter.alertInCelcius(farenheit);
            Debug.Assert(_MopNetworkAlert.celcius == expectedcelcius);


            Console.WriteLine("{0} alerts failed.", alerter.alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }

    }
}
