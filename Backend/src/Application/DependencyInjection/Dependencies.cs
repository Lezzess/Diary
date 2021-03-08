using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection
{
    public static class Dependencies
    {
        #region Public Methods

        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            return services.AddNugetDependencies();
        }

        #endregion

        #region Private Methods

        private static IServiceCollection AddNugetDependencies(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }

        #endregion
    }
}
