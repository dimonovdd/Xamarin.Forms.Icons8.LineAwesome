using System;
using System.Globalization;
using Xamarin.Forms;

namespace Icons8.LineAwesome
{
    public class IconToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => LineAwesomeFont.IconToString(value);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();   
    }
}
