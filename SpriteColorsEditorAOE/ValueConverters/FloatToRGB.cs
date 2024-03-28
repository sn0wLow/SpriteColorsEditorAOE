namespace SpriteColorsEditorAOE
{
    public static class FloatToRGB
    {
        public static byte Convert(float value)
        {
            value = value > 1.0f ? 1.0f : value;
            value = value < 0f ? 0f : value;

            return ((byte)(255 * value));
        }

        public static float ConvertBack(byte value)
        {
            return (value / 255.0f);
        }
    }
}
