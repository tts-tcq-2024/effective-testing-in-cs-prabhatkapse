namespace MisalignedSpace
{
    public class ColorCode 
    {
        private readonly IPrint _print;
        public ColorCode(IPrint print)
        {
            _print = print;
        }

        public int PrintColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

            int i, j = 0;
            int index = 0;
            var colorMap = new List<string>();

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    colorMap.Add($"{i * 5 + j} | {majorColors[i]} | {minorColors[i]}");
                    index++;
                }
            }
            _print.StringList(colorMap);

            return i * j;
        }
    }
}
