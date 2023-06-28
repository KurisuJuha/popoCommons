﻿using System.Reflection;

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
        return AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => GetInterfaces<T>(assembly));
    }

    public static IEnumerable<T> CreateInterfaceInstances<T>(params Assembly[] assemblies) where T : class
    {
        return GetInterfaces<T>(assemblies)
            .Where(c => !c.IsAbstract)
            .Select(c => Activator.CreateInstance(c) as T)
            .NotNull();
    }

    public static IEnumerable<T> CreateInterfaceInstances<T>() where T : class
    {
        return CreateInterfaceInstances<T>(AppDomain.CurrentDomain.GetAssemblies());
    }
}