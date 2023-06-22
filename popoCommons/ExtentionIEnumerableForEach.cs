// ReSharper disable PossibleMultipleEnumeration

namespace JuhaKurisu.PopoTools.Commons;

public static class ExtentionIEnumerableForEach
{
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> self, Action<T> value)
    {
        foreach (var element in self)
        {
            value.Invoke(element);
            yield return element;
        }
    }
}