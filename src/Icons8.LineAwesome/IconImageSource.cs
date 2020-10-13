using Icons8.LineAwesome;
using System;
using Xamarin.Forms;

namespace Icons8.LineAwesome
{
    public class IconImageSource<T> : FontImageSource where T : Enum
    {
        public IconImageSource()
        {
            Size = 30;
            Color = Color.Black;
            UpdateGlyph(Icon);
        }

        public IconImageSource(string fontFamily) : this()
        {
            FontFamily = fontFamily;
        }

        public IconImageSource(T icon, string fontFamily) : this(fontFamily)
        {
            Icon = icon;
        }

        public virtual IconImageSource<T> WithColor(Color color)
        {
            Color = color;
            return this;
        }

        public T Icon
        {
            get => (T)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static BindableProperty IconProperty = BindableProperty.Create(
            propertyName: nameof(Icon),
            returnType: typeof(T),
            declaringType: typeof(IconImageSource<T>),
            defaultValue: default(T),
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: UpdateIcon);


        void UpdateGlyph(T icon) => Glyph = LineAwesomeFont.IconToString(icon);

        static void UpdateIcon(BindableObject bindable, object oldValue, object newValue) => GetInstance(bindable)?.UpdateGlyph((T)newValue);

        static IconImageSource<T> GetInstance(BindableObject bindable) => bindable is IconImageSource<T> imageSource ? imageSource : null; 
    }
}
