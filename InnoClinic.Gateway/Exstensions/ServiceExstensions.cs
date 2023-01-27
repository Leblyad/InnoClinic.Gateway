using InnoClinic.Gateway.Aggregates.Appointment;
using InnoClinic.Gateway.Aggregates.Doctor;
using InnoClinic.Gateway.Aggregates.Service;
using Ocelot.DependencyInjection;

namespace InnoClinic.Gateway.Exstensions
{
    public static class ServiceExstensions
    {
        public static void ConfigureCors(this IServiceCollection services)
            => services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureOcelot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOcelot(configuration)
                .AddSingletonDefinedAggregator<CreateAppointmentByPatient>()
                .AddSingletonDefinedAggregator<CreateAppointmentByReceptionist>()
                .AddSingletonDefinedAggregator<CreateDoctorProfile>()
                .AddSingletonDefinedAggregator<ViewDoctors>()
                .AddSingletonDefinedAggregator<CreateService>();
        }
    }
}
