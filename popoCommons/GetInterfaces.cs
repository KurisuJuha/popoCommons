using System.Reflection;

namespace JuhaKurisu.PopoTools.Commons;

public static partial class PopoReflectionCommons
{
    public static Type[] GetInterfaces<T>()
    {
        return Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(
                c => c
                    .GetInterfaces()
                    .Any(t => t == typeof(T))
                )
            .ToArray();
    }
}