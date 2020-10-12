using System;

namespace Icons8
{
    public enum LineAwesomeType
    {
        Regular,
        Solid,
        Brand
    }

    class LineAwesomeFont 
    {
        public const string regular = "LineAwesomeRegular";
        public const string solid = "LineAwesomeSolid";
        public const string brand = "LineAwesomeBrands";

        public static string GetFontFamily(LineAwesomeType type)
        {
            switch (type)
            {
                case LineAwesomeType.Solid:
                    return solid;
                case LineAwesomeType.Brand:
                    return brand;
                default:
                    return regular;
            }
        }
    }
}

