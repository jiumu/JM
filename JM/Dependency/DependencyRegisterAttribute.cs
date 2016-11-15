using System;

namespace JM.Dependency
{
    /// <summary>
    /// 自动装配标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyRegisterAttribute:Attribute
    {
    }
}
