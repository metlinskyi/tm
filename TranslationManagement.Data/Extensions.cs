namespace TranslationManagement.Data;

using Access;
using EntityFrameworkCore.Triggered;
using Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddDb(this IServiceCollection services, string connectionString)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services.AddDbContext<AppDbContext>(options => {
                options.UseSqlite(connectionString);
                options.UseTriggers();
        })
        .AddScoped<IAfterSaveTrigger<JobRecrod>, JobRecrodAfterSaveTrigger>();
    }

    public static IServiceCollection AddDbIdentity(this IServiceCollection services, string connectionString)
    {
        return services.AddDbContext<AppDbContext>(options => 
                options.UseSqlite(connectionString));
    }
}