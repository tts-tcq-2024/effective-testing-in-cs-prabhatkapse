namespace MisalignedSpace
{
    public class MopPrintOnConsol : IPrint
    {
        public List<string> _colorMap;

        public MopPrintOnConsol()
        {
         _colorMap = new List<string>();
        }

        public void StringList(List<string> colorMap)
        {
            _colorMap = colorMap;

            foreach (var entry in colorMap)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
