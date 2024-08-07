namespace MisalignedSpace
{
    public static class ColorCode
    {
        public static string[] GenerateColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

            int i = 0, j = 0;
            int index = 0;
            string[] colorMap = new string[25];


            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    colorMap[index] = $"{i * 5 + j} | {majorColors[i]} | {minorColors[i]}";
                    index++;
                }
            }
            return colorMap;
        }
    }
}
