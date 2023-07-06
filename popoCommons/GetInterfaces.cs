using System.Reflection;

namespace JuhaKurisu.PopoTools.Commons;

public partial class PopoReflectionCommons
{
    public static IEnumerable<Type> GetInterfaces<T>(params Assembly[] assemblies)
    {
        return assemblies.SelectMany(assembly =>
            assembly.GetTypes().Where(c => c.GetInterfaces().Any(t => t == typeof(T))));
    }

    public static IEnumerable<Type> GetInterfaces<T>()
    {
        return GetInterfaces<T>(AppDomain.CurrentDomain.GetAssemblies());
    }

    public static IEnumerable<T> CreateInterfaceInstances<T>(params Assembly[] assemblies)
    {
        return GetInterfaces<T>(assemblies).CreateInstances<T>();
    }

    public static IEnumerable<T> CreateInterfaceInstances<T>()
    {
        return CreateInterfaceInstances<T>(AppDomain.CurrentDomain.GetAssemblies());
    }
}