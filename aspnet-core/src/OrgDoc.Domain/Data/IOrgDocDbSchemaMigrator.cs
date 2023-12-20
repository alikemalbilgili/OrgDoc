using System.Threading.Tasks;

namespace OrgDoc.Data;

public interface IOrgDocDbSchemaMigrator
{
    Task MigrateAsync();
}
