using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OrgDoc;

[Dependency(ReplaceServices = true)]
public class OrgDocBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OrgDoc";
}
