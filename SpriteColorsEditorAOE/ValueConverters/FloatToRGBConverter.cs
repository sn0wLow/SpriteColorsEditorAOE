using System;
using System.Globalization;

namespace SpriteColorsEditorAOE
{
    public class FloatToRGBConverter : BaseValueConverter<FloatToRGBConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return FloatToRGB.Convert((float)value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return FloatToRGB.ConvertBack(System.Convert.ToByte((double)value));
        }
    }
}
