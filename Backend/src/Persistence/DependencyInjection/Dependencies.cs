using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Services;

namespace Persistence.DependencyInjection
{
    public static class Dependencies
    {
        #region Public Methods

        public static IServiceCollection AddPersistenceDependencies(this IServiceCollection services)
        {
            return services.AddTransient<IDiaryRepository, DiaryRepository>();
        }

        #endregion
    }
}
