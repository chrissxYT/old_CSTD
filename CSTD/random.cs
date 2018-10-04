using System;
using System.Numerics;

namespace CSTD
{
    public static class random
    {
        static Random r = new Random(unchecked((int)((uint)(DateTimeOffset.Now.ToUnixTimeMilliseconds() % uint.MaxValue))));

        public static BigInteger bigint(ulong bit_length) => new BigInteger(bytes(bit_length / 8));

        public static void bytes(byte[] array) => r.NextBytes(array);

        public static byte[] bytes(ulong length)
        {
            byte[] bts = new byte[length];
            bytes(bts);
            return bts;
        }
    }
}
