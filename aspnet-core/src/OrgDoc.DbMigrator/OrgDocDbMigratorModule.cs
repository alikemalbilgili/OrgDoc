using OrgDoc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OrgDoc.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrgDocEntityFrameworkCoreModule),
    typeof(OrgDocApplicationContractsModule)
    )]
public class OrgDocDbMigratorModule : AbpModule
{
}
