using System;
using Autofac;

namespace JM.Dependency
{
    public interface IIocManager:IIocRegistrar,IIocResolver,IDisposable
    {
        /// <summary>
        /// Autofac容器的引用.
        /// Reference to the Autofac container.
        /// </summary>
        IContainer IocContainer { get; }

        /// <summary>
        /// 检查指定类型是否已注册.
        /// Checks whether given type is registered before.
        /// </summary>
        /// <param name="type">Type to check</param>
        /// <returns></returns>
        bool IsRegistered(Type type);

        /// <summary>
        /// 检查指定类型是否已注册.
        /// Checks whether given type is registered before.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool IsRegistered<T>();
    }
}
