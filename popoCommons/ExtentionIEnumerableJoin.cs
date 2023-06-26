namespace JuhaKurisu.PopoTools.Commons;

public static class ExtentionIEnumerableJoin
{
    public static string Join<T>(this IEnumerable<T> self, char separator)
    {
        return string.Join(separator, self);
    }

    public static string Join<T>(this IEnumerable<T> self, string separator)
    {
        return string.Join(separator, self);
    }
}