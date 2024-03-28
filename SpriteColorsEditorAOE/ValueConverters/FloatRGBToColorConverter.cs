using System;
using System.Globalization;
using System.Windows.Media;

namespace SpriteColorsEditorAOE
{
    public class FloatRGBToColorConverter : BaseValueConverter<FloatRGBToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var floatRGBA = (IFloatRGBA)value;
            return new SolidColorBrush(Color.FromArgb(255, FloatToRGB.Convert(floatRGBA.R),
                FloatToRGB.Convert(floatRGBA.G), FloatToRGB.Convert(floatRGBA.B)));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
