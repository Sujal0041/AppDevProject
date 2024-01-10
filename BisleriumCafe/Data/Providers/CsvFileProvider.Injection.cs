namespace BisleriumCafe.Data.Providers;

internal static class CSVFileProviderInjection
{
    public static IServiceCollection AddCsvFileProvider(this IServiceCollection services)
    {
        return services.AddSingleton<FileProvider<User>, CsvFileProvider<User>>()
            .AddSingleton<FileProvider<Spare>, CsvFileProvider<Spare>>()
            .AddSingleton<FileProvider<Product>, CsvFileProvider<Product>>() //
            .AddSingleton<FileProvider<Member>, CsvFileProvider<Member>>() //
            .AddSingleton<FileProvider<Transaction>, CsvFileProvider<Transaction>>() //
            .AddSingleton<FileProvider<ActivityLog>, CsvFileProvider<ActivityLog>>();
    }
}
