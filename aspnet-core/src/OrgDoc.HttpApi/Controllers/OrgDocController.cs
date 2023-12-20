using OrgDoc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrgDoc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OrgDocController : AbpControllerBase
{
    protected OrgDocController()
    {
        LocalizationResource = typeof(OrgDocResource);
    }
}
