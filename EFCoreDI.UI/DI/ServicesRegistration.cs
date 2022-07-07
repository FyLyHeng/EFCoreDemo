using Microsoft.Extensions.DependencyInjection;

namespace EFCoreDI.UI.DI
{
    public class ServiceRegistration
    {
        private static IServiceProvider _serviceProvider;
        
        public static T GetIService<T>()where T : notnull
        {
            if (_serviceProvider == null)
            {
                throw new NullReferenceException($"{typeof(T)} not found in {nameof(ServiceRegistration)}");
            }
            
            var serviceProvider = _serviceProvider.GetRequiredService(typeof(T));
            if (serviceProvider == null)
            {
                throw new NullReferenceException($"[{typeof(T)}] Not Found In Dependency Injection Container [{nameof(ServiceRegistration)}]");
            }
            return (T)serviceProvider;

        }
        
        public static object GetService(Type serviceType)
        {
            if (_serviceProvider == null)
            {
                throw new NullReferenceException($"Bean Container Not Found {nameof(ServiceRegistration)}");
            }
            var serviceProvider = _serviceProvider.GetRequiredService(serviceType);
            if (serviceProvider == null)
            {
                throw new NullReferenceException($"[{serviceType}] Not Found In Dependency Injection Container [{nameof(ServiceRegistration)}]");
            }
            return serviceProvider;
        }
        
        
        
        
        public static void RegisterServices()
        {
            var serviceProvider = new ServiceCollection()
                    .AddSingleton<MyDelete>()
                    .AddSingleton<Removes>()
                    .AddSingleton<Clear>()
                    .AddSingleton<IDynamicFun>()
                ;

            _serviceProvider = serviceProvider.BuildServiceProvider(true);
        }
        
        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
