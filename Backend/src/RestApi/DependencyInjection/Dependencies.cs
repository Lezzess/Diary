using Microsoft.Extensions.DependencyInjection;

namespace RestApi.DependencyInjection
{
    public static class Dependencies
    {
        #region Constants

        private const string FrontendDevelopmentDomain = "http://localhost:4200";

        #endregion

        #region Public Methods

        public static IServiceCollection AddRestApiDependencies(this IServiceCollection services)
        {
            services.AddCors(
                options => options.AddDefaultPolicy(
                    builder => builder.WithOrigins(FrontendDevelopmentDomain)));

            services.AddControllers();

            return services;
        }

        #endregion
    }
}
