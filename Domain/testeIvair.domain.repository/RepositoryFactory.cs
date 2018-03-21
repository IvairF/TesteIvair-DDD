using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using testeIvair.infrastructure.persistence;
using testeIvair.domain.repository.interfaces;


namespace testeIvair.domain.repository
{
    public static class RepositoryFactory
    {
        public static IRepository<T> CreateRepository<T, R>(IUnitOfWork unitOfWork)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType(typeof(IRepository<T>), typeof(R)).RegisterInstance(unitOfWork);

            return container.Resolve<IRepository<T>>();
        }
 
    }
}