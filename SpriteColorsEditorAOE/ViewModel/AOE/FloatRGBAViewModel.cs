namespace SpriteColorsEditorAOE
{
    public class FloatRGBAViewModel : BaseViewModel, IFloatRGBA
    {
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public string ARGB
        {
            get
            {
                int a = (int)(A * 255);
                int r = (int)(R * 255);
                int g = (int)(G * 255);
                int b = (int)(B * 255);

                return $"{a:X2}{r:X2}{g:X2}{b:X2}";
            }
            set
            {
                int argbInt = int.Parse(value, System.Globalization.NumberStyles.HexNumber);

                A = ((argbInt >> 24) & 0xFF) / 255.0f;
                R = ((argbInt >> 16) & 0xFF) / 255.0f;
                G = ((argbInt >> 8) & 0xFF) / 255.0f;
                B = (argbInt & 0xFF) / 255.0f;
            }
        }
    }
}
