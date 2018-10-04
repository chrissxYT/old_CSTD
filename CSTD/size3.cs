namespace CSTD.DRAWING
{
    public struct size3_8
    {
        public sbyte width, height, depth;

        public size3_8(sbyte width, sbyte height, sbyte depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct usize3_8
    {
        public byte width, height, depth;

        public usize3_8(byte width, byte height, byte depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct size3_16
    {
        public short width, height, depth;

        public size3_16(short width, short height, short depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct usize3_16
    {
        public ushort width, height, depth;

        public usize3_16(ushort width, ushort height, ushort depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct size3_32
    {
        public int width, height, depth;

        public size3_32(int width, int height, int depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct usize3_32
    {
        public uint width, height, depth;

        public usize3_32(uint width, uint height, uint depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct size3_64
    {
        public long width, height, depth;

        public size3_64(long width, long height, long depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }

    public struct usize3_64
    {
        public ulong width, height, depth;

        public usize3_64(ulong width, ulong height, ulong depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
    }
}
