using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned 
    {
        static void Main(string[] args) {

            ColorCode colorCode;

            colorCode = new ColorCode(new PrintOnConsol());

            var result = colorCode.PrintColorMap();

            Debug.Assert(result == 25);

            var MopPrintOnConsol = new MopPrintOnConsol();
            colorCode = new ColorCode(MopPrintOnConsol);
            colorCode.PrintColorMap();
            var colorMap = MopPrintOnConsol._colorMap;

            Debug.Assert(colorMap[0] ==  "1 | White | Blue");
            Debug.Assert(colorMap[1] ==  "2 | White | Orange");
            Debug.Assert(colorMap[8] ==  "9 | Red | Brown");
            Debug.Assert(colorMap[13] == "14 | Black | Brown");
            Debug.Assert(colorMap[17] == "18 | Yellow | Green");
            Debug.Assert(colorMap[22] == "23 | Violet | Green");
            Debug.Assert(colorMap[24] == "25 | Violet | Slate");

            Debug.Assert(colorMap[0] ==  "01 | White  | Blue");
            Debug.Assert(colorMap[8] ==  "09 | Red    | Brown");
            Debug.Assert(colorMap[17] == "18 | Yellow | Green");
            Debug.Assert(colorMap[22] == "23 | Violet | Green");

            Console.WriteLine("All is well (maybe!)");
        }
    }
}
