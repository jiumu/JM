using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.Dependency
{
    /// <summary>
    /// 定义接口类用于注册依赖项.
    /// Define interface for classes those are used to register dependencies.
    /// </summary>
    public interface IIocRegistrar
    {
        void RegisterType<T>() where T : class,new();
        void RegisterType(Type type);
        void RegisterType<TType, TService>() where TType : class, new();
        void RegisterType(Type type, Type service);

        void RegisterType(Type type, params Type[] services);
       
    }
}
