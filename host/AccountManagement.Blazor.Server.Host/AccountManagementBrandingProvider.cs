using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AccountManagement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class AccountManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AccountManagement";
}
