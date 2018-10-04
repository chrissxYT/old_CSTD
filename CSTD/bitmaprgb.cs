namespace CSTD.DRAWING
{
    public struct ubitmaprgb_32
    {
        public color_rgb[] pixels;
        public usize2_32 size;

        public ubitmaprgb_32(usize2_32 size)
        {
            this.size = size;
            pixels = new color_rgb[size.width * size.height];
        }

        public ubitmaprgb_32(usize2_32 size, color_rgb[] pixels)
        {
            this.size = size;
            this.pixels = pixels;
        }

        public color_rgb getpixel(upoint2_32 point) => pixels[point.y * size.width + point.x - 1];

        public void setpixel(upoint2_32 point, color_rgb color) => pixels[point.y * size.width + point.x - 1] = color;
    }
}
