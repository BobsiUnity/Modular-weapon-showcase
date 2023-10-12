using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public static class CustomExtensions
{
    public static T GetRandom<T>(this IList<T> list)
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Cannot select a random element from an empty list");
        }

        return list[Random.Range(0, list.Count)];
    }
}
