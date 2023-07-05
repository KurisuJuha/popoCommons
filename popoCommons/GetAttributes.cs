using System.Reflection;

namespace JuhaKurisu.PopoTools.Commons;

public partial class PopoReflectionCommons
{
    public PropertyInfo[] GetProperties<T>(BindingFlags bindingFlags)
    {
        return typeof(T).GetProperties(bindingFlags);
    }

    public MethodInfo[] GetMethods<T>(BindingFlags bindingFlags)
    {
        return typeof(T).GetMethods(bindingFlags);
    }
}