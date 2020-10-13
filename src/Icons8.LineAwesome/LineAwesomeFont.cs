using System;

namespace Icons8.LineAwesome
{
    public class LineAwesomeFont
    {
        public const string regular = "LineAwesomeRegular";
        public const string solid = "LineAwesomeSolid";
        public const string brand = "LineAwesomeBrands";

        public static string IconToString(object obj) => obj is Enum val ? $"{Convert.ToChar(val)}" : null;
    }
}

