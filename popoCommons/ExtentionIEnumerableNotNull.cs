namespace JuhaKurisu.PopoTools.Commons;

public static class ExtentionIEnumerableNotNull
{
    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?> self)
    {
        return (IEnumerable<T>)self.Where(c => c != null);
    }
}