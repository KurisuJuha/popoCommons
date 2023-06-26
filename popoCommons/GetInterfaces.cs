using System.Reflection;

namespace JuhaKurisu.PopoTools.Commons;

public static class PopoReflectionCommons
{
    public static IEnumerable<Type> GetInterfaces<T>(Assembly assembly)
    {
        return assembly.GetTypes().Where(c => c.GetInterfaces().Any(t => t == typeof(T)));
    }

    public static IEnumerable<Type> GetInterfaces<T>()
    {
        return AppDomain.CurrentDomain.GetAssemblies().SelectMany(GetInterfaces<T>);
    }

    public static IEnumerable<T> CreateInterfaceInstances<T>() where T : class
    {
        return GetInterfaces<T>()
            .Where(c => !c.IsAbstract)
            .Select(c => Activator.CreateInstance(c) as T)
            .NotNull();
    }
}