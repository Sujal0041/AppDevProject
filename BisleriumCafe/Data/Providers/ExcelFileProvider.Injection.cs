namespace BisleriumCafe.Data.Providers;

internal static class ExcelFileProviderInjection
{
    public static IServiceCollection AddExcelFileProvider(this IServiceCollection services)
    {
        return services.AddSingleton<FileProvider<User>, ExcelFileProvider<User>>()
            .AddSingleton<FileProvider<Spare>, ExcelFileProvider<Spare>>()
            .AddSingleton<FileProvider<Product>, ExcelFileProvider<Product>>() //
            .AddSingleton<FileProvider<Member>, ExcelFileProvider<Member>>() //
            .AddSingleton<FileProvider<Transaction>, CsvFileProvider<Transaction>>() //
            .AddSingleton<FileProvider<ActivityLog>, ExcelFileProvider<ActivityLog>>();
    }
}
