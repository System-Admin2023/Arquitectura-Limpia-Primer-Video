namespace NothWind.Repositories.EFCore.DataContext
{
    internal interface IDisignTimeDbContextFactory<T>
    {
        NorthWindContext CreateDbContext(string[] args);
    }
}