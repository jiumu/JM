using System;

namespace JM.Dependency
{
    /// <summary>
    /// 自动装配标记,返回新的实例
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyPerAttribute:Attribute
    {
    }
    /// <summary>
    /// 自动装配标记,单例
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencySingleAttribute : Attribute { }

    /// <summary>
    /// 自动装配标记,同一工作单元共享
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyPerLifetimeScopeAttribute : Attribute { }
}
