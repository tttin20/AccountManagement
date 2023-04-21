using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AccountManagement;

[Dependency(ReplaceServices = true)]
public class AccountManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AccountManagement";
}
