namespace MisalignedSpace
{
    public class PrintOnConsol : IPrint
    {
        public void StringList(List<string> colorMap)
        {
            foreach (var entry in colorMap)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
