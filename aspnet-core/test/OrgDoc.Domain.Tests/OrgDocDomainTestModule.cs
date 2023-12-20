using Volo.Abp.Modularity;

namespace OrgDoc;

[DependsOn(
    typeof(OrgDocDomainModule),
    typeof(OrgDocTestBaseModule)
)]
public class OrgDocDomainTestModule : AbpModule
{

}
