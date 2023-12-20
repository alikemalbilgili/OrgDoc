using Volo.Abp.Modularity;

namespace OrgDoc;

public abstract class OrgDocApplicationTestBase<TStartupModule> : OrgDocTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
