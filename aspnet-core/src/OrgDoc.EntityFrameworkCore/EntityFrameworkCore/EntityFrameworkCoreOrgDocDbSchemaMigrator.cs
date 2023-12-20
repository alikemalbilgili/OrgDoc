using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrgDoc.Data;
using Volo.Abp.DependencyInjection;

namespace OrgDoc.EntityFrameworkCore;

public class EntityFrameworkCoreOrgDocDbSchemaMigrator
    : IOrgDocDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOrgDocDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the OrgDocDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OrgDocDbContext>()
            .Database
            .MigrateAsync();
    }
}
