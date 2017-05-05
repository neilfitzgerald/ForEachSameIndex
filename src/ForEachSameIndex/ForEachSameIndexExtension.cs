using System;
using System.Collections;
using System.Collections.Generic;

namespace ForEachSameIndex
{
    public static class ForEachSameIndexExtension
    {
        public static void ForEachSameIndex<T1, T2>(this IList<T1> currentList, IList<T2> listT2, Action<T1, T2> action)
        {
            if (currentList.Count != listT2.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, Action<T1, T2, T3> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, Action<T1, T2, T3, T4> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, Action<T1, T2, T3, T4, T5> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, IList<T12> listT12, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count
                || listT11.Count != listT12.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i], listT12[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, IList<T12> listT12, IList<T13> listT13, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count
                || listT11.Count != listT12.Count
                || listT12.Count != listT13.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i], listT12[i], listT13[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, IList<T12> listT12, IList<T13> listT13, IList<T14> listT14, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count
                || listT11.Count != listT12.Count
                || listT12.Count != listT13.Count
                || listT13.Count != listT14.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i], listT12[i], listT13[i], listT14[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, IList<T12> listT12, IList<T13> listT13, IList<T14> listT14, IList<T15> listT15, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count
                || listT11.Count != listT12.Count
                || listT12.Count != listT13.Count
                || listT13.Count != listT14.Count
                || listT14.Count != listT15.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i], listT12[i], listT13[i], listT14[i], listT15[i]);
            }
        }

        public static void ForEachSameIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IList<T1> currentList, IList<T2> listT2, IList<T3> listT3, IList<T4> listT4, IList<T5> listT5, IList<T6> listT6, IList<T7> listT7, IList<T8> listT8, IList<T9> listT9, IList<T10> listT10, IList<T11> listT11, IList<T12> listT12, IList<T13> listT13, IList<T14> listT14, IList<T15> listT15, IList<T16> listT16, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            if (currentList.Count != listT2.Count
                || listT2.Count != listT3.Count
                || listT3.Count != listT4.Count
                || listT4.Count != listT5.Count
                || listT5.Count != listT6.Count
                || listT6.Count != listT7.Count
                || listT7.Count != listT8.Count
                || listT8.Count != listT9.Count
                || listT9.Count != listT10.Count
                || listT10.Count != listT11.Count
                || listT11.Count != listT12.Count
                || listT12.Count != listT13.Count
                || listT13.Count != listT14.Count
                || listT14.Count != listT15.Count
                || listT15.Count != listT16.Count)
            {
                throw new ArgumentException("Size of lists must be the same.");
            }
            for (int i = 0; i < currentList.Count; i++)
            {
                action(currentList[i], listT2[i], listT3[i], listT4[i], listT5[i], listT6[i], listT7[i], listT8[i], listT9[i], listT10[i], listT11[i], listT12[i], listT13[i], listT14[i], listT15[i], listT16[i]);
            }
        }
    }
}