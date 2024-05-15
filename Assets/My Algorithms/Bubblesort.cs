using System;
using UnityEngine.Assertions;

public static class Bubblesort
{
    public static T[] Sort<T>(T[] array) where T : IComparable
    {
        Assert.IsNotNull(array);
        if (array.Length <= 1)
        {
            return array;
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                int comp = array[i].CompareTo(array[j]);
                if (comp > 0)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }
        return array;
    }
}
