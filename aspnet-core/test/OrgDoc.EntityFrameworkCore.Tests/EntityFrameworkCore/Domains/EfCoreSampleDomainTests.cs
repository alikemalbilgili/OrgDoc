using OrgDoc.Samples;
using Xunit;

namespace OrgDoc.EntityFrameworkCore.Domains;

[Collection(OrgDocTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OrgDocEntityFrameworkCoreTestModule>
{

}
