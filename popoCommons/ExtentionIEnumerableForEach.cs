// ReSharper disable PossibleMultipleEnumeration

namespace JuhaKurisu.PopoTools.Commons;

public static class ExtentionIEnumerableForEach
{
    public static void ForEach<T>(this IEnumerable<T> self, Action<T> value)
    {
        foreach (var element in self) value.Invoke(element);
    }
}