using Volo.Abp.Modularity;

namespace OrgDoc;

/* Inherit from this class for your domain layer tests. */
public abstract class OrgDocDomainTestBase<TStartupModule> : OrgDocTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
