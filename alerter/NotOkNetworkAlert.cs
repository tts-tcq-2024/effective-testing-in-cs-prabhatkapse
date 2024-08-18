namespace AlerterSpace
{
    public class NotOkNetworkAlert : INetworkAlert
    {
        public int AlertNetwork(float _celcius)
        {
            return 500;
        }
    }

}
