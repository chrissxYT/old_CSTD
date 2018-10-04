namespace CSTD.DRAWING
{
    public struct color_rgb
    {
        public byte r, g, b;

        public color_rgb(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }

    public struct color_argb
    {
        public byte a, r, g, b;

        public color_argb(byte a, byte r, byte g, byte b)
        {
            this.a = a;
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
