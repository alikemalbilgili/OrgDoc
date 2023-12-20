using Volo.Abp.Modularity;

namespace OrgDoc;

[DependsOn(
    typeof(OrgDocApplicationModule),
    typeof(OrgDocDomainTestModule)
)]
public class OrgDocApplicationTestModule : AbpModule
{

}
