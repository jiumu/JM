using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace JM.Dependency
{
    public class IocManager : IIocManager
    {
        /// <summary>
        /// 单列实例
        /// </summary>
        public static IocManager Instance { get; private set; }
        static IocManager()
        {
            Instance = new IocManager();
        }
        public IocManager()
        {
            //注册
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<IocManager>()
                .AsSelf()
                .As<IIocManager>()
                .As<IIocRegistrar>()
                .As<IIocResolver>();
            //创建容器.
            IocContainer = builder.Build();
        }
        /// <summary>
        /// Autofac容器
        /// </summary>
        public IContainer IocContainer { get; private set; }
        
        public void Dispose()
        {
            IocContainer.Dispose();
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定类型是否注册.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsRegistered(Type type)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 指定类型是否注册.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool IsRegistered<T>()
        {
            throw new NotImplementedException();
        }
    }
}
