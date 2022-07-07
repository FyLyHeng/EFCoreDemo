using EFCoreDI.Service.Base;
using Microsoft.Extensions.DependencyInjection;
using AppContext = EFCoreDI.Domain.AppContext;

namespace EFCoreDI.Service.DI
{
    public class ServiceRegistration
    {
        private static IServiceProvider _serviceProvider;
        
        public static T GetService<T>()where T : notnull
        {
            if (_serviceProvider == null)
            {
                throw new NullReferenceException($"{typeof(T)} not found in {nameof(ServiceRegistration)}");
            }
            
            var serviceProvider = _serviceProvider.GetService(typeof(T));
            if (serviceProvider == null)
            {
                throw new NullReferenceException($"[{typeof(T)}] Not Found In Dependency Injection Container [{nameof(ServiceRegistration)}]");
            }
            return (T)serviceProvider;

        }
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
        
        public static void RegisterServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton(typeof(IBaseService<>), typeof(BaseService<>))
                //.AddSingleton<IAppContext, AppContext>()
                .AddSingleton<AppContext>()
                .AddSingleton<IEmployeeService, EmployeeService>()
                .AddSingleton<ISaleService, SaleService>()
                .AddSingleton<IInvoiceService, InvoiceService>();
            
            _serviceProvider = serviceProvider.BuildServiceProvider(true);
            //DisposeServices();
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
