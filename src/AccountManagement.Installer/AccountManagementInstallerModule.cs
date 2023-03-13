using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AccountManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AccountManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AccountManagementInstallerModule>();
        });
    }
}
