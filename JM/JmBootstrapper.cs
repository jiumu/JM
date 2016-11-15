using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM.Dependency;

namespace JM
{
    public class JmBootstrapper : IDisposable
    {
        /// <summary>
        /// ioc实例
        /// </summary>
        public IIocManager IocManager { get; private set; }
        
        public JmBootstrapper() 
            : this(Dependency.IocManager.Instance)
        {

        }

        public JmBootstrapper(IIocManager iocManager)
        {
            this.IocManager = iocManager;
        }
        /// <summary>
        /// 初始化JMFramework.
        /// </summary>
        public virtual void Init()
        {

        }

        protected  bool IsDisposed;
        public virtual void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }
            IsDisposed = true;
            //做释放操作
        }
    }
}
