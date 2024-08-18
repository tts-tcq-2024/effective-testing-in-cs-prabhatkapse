namespace AlerterSpace
{
    public class MopNetworkAlert : INetworkAlert
    {
        public float celcius;

        public MopNetworkAlert()
        {
            celcius = new float();
        }
        public int AlertNetwork(float _celcius)
        {
            celcius = _celcius;
            Console.WriteLine("ALERT: Temperature is {0} celcius", _celcius);
            return 200;
        }
    } 

}
