namespace CSTD.DRAWING
{
    public struct point3_8
    {
        public sbyte x, y, z;

        public point3_8(sbyte x, sbyte y, sbyte z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct upoint3_8
    {
        public byte x, y, z;

        public upoint3_8(byte x, byte y, byte z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct point3_16
    {
        public short x, y, z;

        public point3_16(short x, short y, short z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct upoint3_16
    {
        public ushort x, y, z;

        public upoint3_16(ushort x, ushort y, ushort z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct point3_32
    {
        public int x, y, z;

        public point3_32(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct upoint3_32
    {
        public uint x, y, z;

        public upoint3_32(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct point3_64
    {
        public long x, y, z;

        public point3_64(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public struct upoint3_64
    {
        public ulong x, y, z;

        public upoint3_64(ulong x, ulong y, ulong z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
