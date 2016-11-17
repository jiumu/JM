using Autofac;


namespace JM.Dependency
{
    public class DefaultConventionalRegistratrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(context.Assembly)
                .Where(t => t.GetCustomAttributes(typeof(DependencyPerAttribute), false) != null)
                .AsImplementedInterfaces()
                .InstancePerDependency();

            builder.RegisterAssemblyTypes(context.Assembly)
                .Where(t => t.GetCustomAttributes(typeof(DependencySingleAttribute), false) != null)
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterAssemblyTypes(context.Assembly)
                .Where(t => t.GetCustomAttributes(typeof(DependencyPerLifetimeScopeAttribute), false) != null)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.Update(context.IocManager.IocContainer);
        }
    }
}
