using DevFramework.Nortwind.Business.ValidationRules.FluentValidation;
using DevFramework.Nortwind.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace DevFramework.Nortwind.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidatior>().InSingletonScope();
        }
    }
}