using Autofac;


namespace JM.Dependency
{
    public class DefaultConventionalRegistratrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(context.Assembly)
                .Where(t => t.GetCustomAttributes(typeof(DependencyRegisterAttribute), false) != null)
                .AsImplementedInterfaces()
                .InstancePerDependency();


            builder.Update(context.IocManager.IocContainer);
        }
    }
}
