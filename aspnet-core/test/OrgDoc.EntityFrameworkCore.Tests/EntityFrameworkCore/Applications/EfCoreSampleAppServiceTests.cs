using OrgDoc.Samples;
using Xunit;

namespace OrgDoc.EntityFrameworkCore.Applications;

[Collection(OrgDocTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OrgDocEntityFrameworkCoreTestModule>
{

}
