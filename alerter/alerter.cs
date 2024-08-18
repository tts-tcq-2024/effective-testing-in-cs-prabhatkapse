namespace AlerterSpace
{
    public class Alerter
    {
        public int alertFailureCount = 0;
        private readonly INetworkAlert _networkAlert;

        public Alerter(INetworkAlert networkAlert)
        {
            _networkAlert = networkAlert;
        }
        public void alertInCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = _networkAlert.AlertNetwork(celcius);

            if (returnCode != 200) 
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
    }

  
}
