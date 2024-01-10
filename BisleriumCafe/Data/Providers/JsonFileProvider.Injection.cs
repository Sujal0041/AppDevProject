namespace BisleriumCafe.Data.Providers;

internal static class JsonFileProvider
{
    public static IServiceCollection AddJsonFileProvider(this IServiceCollection services)
    {
        return services.AddSingleton<FileProvider<User>, JsonFileProvider<User>>()
            .AddSingleton<FileProvider<Spare>, JsonFileProvider<Spare>>()
            .AddSingleton<FileProvider<Product>, JsonFileProvider<Product>>() //
            .AddSingleton<FileProvider<Member>, JsonFileProvider<Member>>() //
            .AddSingleton<FileProvider<Transaction>, CsvFileProvider<Transaction>>() //
            .AddSingleton<FileProvider<ActivityLog>, JsonFileProvider<ActivityLog>>();
    }
}
