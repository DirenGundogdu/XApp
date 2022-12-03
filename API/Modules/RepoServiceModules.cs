using Module = Autofac.Module;
using Repository;
using Service.Mapping;
using System.Reflection;
using Autofac;
using Repository.Repositories;
using Core.Repositories;
using Service.Services;
using Core.Services;
using Repository.UnitOfWorks;
using Core.UnitOfWorks;
using Caching;

namespace API.Modules
{
    public class RepoServiceModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


            //InstancePerLifetimeScope => scope
            //InstancePerRequest => transient
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();


        }
    }
}
