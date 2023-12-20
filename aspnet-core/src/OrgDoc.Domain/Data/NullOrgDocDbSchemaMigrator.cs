using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrgDoc.Data;

/* This is used if database provider does't define
 * IOrgDocDbSchemaMigrator implementation.
 */
public class NullOrgDocDbSchemaMigrator : IOrgDocDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
