using System;
using System.Collections.Generic;
using System.Text;
using OrgDoc.Localization;
using Volo.Abp.Application.Services;

namespace OrgDoc;

/* Inherit your application services from this class.
 */
public abstract class OrgDocAppService : ApplicationService
{
    protected OrgDocAppService()
    {
        LocalizationResource = typeof(OrgDocResource);
    }
}
