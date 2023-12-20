using Xunit;

namespace OrgDoc.EntityFrameworkCore;

[CollectionDefinition(OrgDocTestConsts.CollectionDefinitionName)]
public class OrgDocEntityFrameworkCoreCollection : ICollectionFixture<OrgDocEntityFrameworkCoreFixture>
{

}
