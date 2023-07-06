namespace JuhaKurisu.PopoTools.Commons;

public static class ExtentionIEnumerableCreateInstances
{
    public static IEnumerable<object> CreateInstances(this IEnumerable<Type> types)
    {
        return types.Where(t => !t.IsAbstract)
            .Select(Activator.CreateInstance)
            .NotNull();
    }

    public static IEnumerable<T> CreateInstances<T>(this IEnumerable<Type> types)
    {
        return types.CreateInstances().OfType<T>();
    }
}