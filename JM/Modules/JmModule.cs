using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM.Dependency;

namespace JM.Modules
{
    public abstract class JmModule
    {
        /// <summary>
        /// ioc容器实例
        /// </summary>
        protected internal IIocManager IocManager { get; internal set; }

        /// <summary>
        /// 初始化之前
        /// </summary>
        public virtual void PreInitialize()
        {

        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void Initialize()
        {

        }
        /// <summary>
        /// 初始化之后
        /// </summary>
        public virtual void PostInitialize()
        {

        }
        /// <summary>
        /// 关闭
        /// </summary>
        public virtual void ShutDown()
        {

        }

        /// <summary>
        /// 是否为JM模块
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsJmModule(Type type)
        {
            return
                type.IsClass &&
                !type.IsAbstract &&
                typeof(JmModule).IsAssignableFrom(type);
        }
    }
}
