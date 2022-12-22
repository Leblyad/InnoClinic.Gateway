using Microsoft.IdentityModel.Tokens;

namespace InnoClinic.Gateway
{
    public static class ServiceExstensions
    {
        public static void ConfigureJWTAuthentification(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication("Bearer")
                    .AddJwtBearer("Bearer", options =>
                    {
                        options.Authority = configuration.GetValue<string>("Routes:AuthorityRoute");
                        options.Audience = "APIClient";
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateAudience = true,
                            ValidAudience = "APIClient"
                        };
                    });
        }

        public static void ConfigureCors(this IServiceCollection services)
            => services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
    }
}
