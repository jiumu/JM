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

        public void RegisterType<T>() where T : class, new()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<T>();
            builder.Update(this.IocContainer);
        }

        public void RegisterType(Type type)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType(type);
            builder.Update(this.IocContainer);
        }

        public void RegisterType<TType, TService>() where TType : class, new()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<TType>().As<TService>();
            builder.Update(this.IocContainer);
        }

        public void RegisterType(Type type, Type service)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType(type).As(service);
            builder.Update(this.IocContainer);
        }

        public void RegisterType(Type type, params Type[] services)
        {
            ContainerBuilder builder = new ContainerBuilder();
            var resBuilder= builder.RegisterType(type);
            if (services.Length>0)
            {
                resBuilder = resBuilder.AsSelf();
                foreach (Type item in services)
                {
                    resBuilder = resBuilder.As(item);
                }
            }
            builder.Update(this.IocContainer);
        }
        
    }
}
