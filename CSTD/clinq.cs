using System.Collections.Generic;

namespace CSTD.CLINQ
{
    public static class clinq
    {
        public static T[] reverse<T>(this T[] array)
        {
            T[] arr = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                arr[i] = array[array.Length - i - 1];
            return arr;
        }

        public static List<T> reverse<T>(this List<T> list)
        {
            List<T> lst = new List<T>();
            for (int i = 0; i < list.Count; i++)
                lst[i] = list[list.Count - i - 1];
            return lst;
        }

        public static T[] to_array<T>(this IEnumerable<T> enumerable) => new List<T>(enumerable).ToArray();
    }
}
