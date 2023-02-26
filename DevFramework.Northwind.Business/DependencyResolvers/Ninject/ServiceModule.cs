using DevFramework.Core.Utilities.Common;
using DevFramework.Nortwind.Business.Abstract;
using Ninject.Modules;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }
    }
}
