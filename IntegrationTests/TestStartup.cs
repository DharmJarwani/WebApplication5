using Microsoft.Extensions.DependencyInjection;
using WebApplication5.Repositories;
using WebApplication5.Services;

namespace IntegrationTests
{
    public class TestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, MockStudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
