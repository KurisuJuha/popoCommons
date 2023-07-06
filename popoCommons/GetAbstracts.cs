using System.Reflection;

namespace JuhaKurisu.PopoTools.Commons;

public partial class PopoReflectionCommons
{
    public static IEnumerable<Type> GetAbstracts<T>(params Assembly[] assemblies)
    {
        return assemblies.SelectMany(assembly => assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(T))));
    }

    public static IEnumerable<Type> GetAbstracts<T>()
    {
        return GetAbstracts<T>(AppDomain.CurrentDomain.GetAssemblies());
    }

    public static IEnumerable<T> CreateAbstractInstances<T>(params Assembly[] assemblies)
    {
        return GetAbstracts<T>(assemblies).CreateInstances<T>();
    }

    public static IEnumerable<T> CreateAbstractInstances<T>()
    {
        return CreateAbstractInstances<T>(AppDomain.CurrentDomain.GetAssemblies());
    }
}