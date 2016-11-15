using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JM.Dependency
{
    internal class ConventionalRegistrationContext : IConventionalRegistrationContext
    {
        public Assembly Assembly
        {
            get;
            private set;
        }

        public IIocManager IocManager
        {
            get;
            private set;
        }

        internal ConventionalRegistrationContext(Assembly assembly, IIocManager icoManager)
        {
            this.Assembly = assembly;
            this.IocManager = IocManager;
        }
    }
}
