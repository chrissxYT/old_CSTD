namespace CSTD.DRAWING
{
    public struct ubitmapargb_32
    {
        public color_argb[] pixels;
        public usize2_32 size;

        public ubitmapargb_32(usize2_32 size)
        {
            this.size = size;
            pixels = new color_argb[size.width * size.height];
        }

        public ubitmapargb_32(usize2_32 size, color_argb[] pixels)
        {
            this.size = size;
            this.pixels = pixels;
        }

        public color_argb getpixel(upoint2_32 point) => pixels[point.y * size.width + point.x - 1];

        public void setpixel(upoint2_32 point, color_argb color) => pixels[point.y * size.width + point.x - 1] = color;
    }
}
