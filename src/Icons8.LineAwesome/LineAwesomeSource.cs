using System;
using Xamarin.Forms;

namespace Icons8
{
    public class LineAwesomeSource : FontImageSource
    {
        public LineAwesomeSource()
        {
            IconType = LineAwesomeType.Regular;
            FontFamily = LineAwesomeFont.GetFontFamily(IconType);
            Size = 30;
        }

        public LineAwesomeSource(LineAwesomeGlyph icon, LineAwesomeType iconType = LineAwesomeType.Regular)
        {
            Icon = icon;
            IconType = iconType;
            FontFamily = LineAwesomeFont.GetFontFamily(IconType);
            Size = 30;
        }

        public LineAwesomeSource WithColor(Color color)
        {
            Color = color;
            return this;
        }

        public LineAwesomeGlyph Icon
        {
            get => (LineAwesomeGlyph)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static BindableProperty IconProperty = BindableProperty.Create(
            propertyName: nameof(Icon),
            returnType: typeof(LineAwesomeGlyph),
            declaringType: typeof(LineAwesomeSource),
            defaultValue: default(LineAwesomeGlyph),
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: UpdateIcon);

        private static void UpdateIcon(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is LineAwesomeSource fontImageSource)
                fontImageSource.Glyph = Convert.ToString((char)(LineAwesomeGlyph)newValue);
        }

        public LineAwesomeType IconType
        {
            get => (LineAwesomeType)GetValue(IconTypeProperty);
            set => SetValue(IconTypeProperty, value);
        }

        public static BindableProperty IconTypeProperty = BindableProperty.Create(
            propertyName: nameof(IconType),
            returnType: typeof(LineAwesomeType),
            declaringType: typeof(LineAwesomeSource),
            defaultValue: default(LineAwesomeType),
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: UpdateIconType);

        private static void UpdateIconType(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is LineAwesomeSource fontImageSource)
                fontImageSource.FontFamily = LineAwesomeFont.GetFontFamily(fontImageSource.IconType);
        }    
    }
}
