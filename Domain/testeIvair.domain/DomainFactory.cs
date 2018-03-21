using Microsoft.Practices.Unity;

using testeIvair.domain.interfaces;
using testeIvair.infrastructure.persistence;

namespace testeIvair.domain
{
    public static class DomainFactory
    {
        public static IOperation CreateDomain<O>()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType(typeof(IOperation), typeof(O));

            return container.Resolve<IOperation>(); 
        }
    }
}