using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace AccountManagement.Web.Menus;

public class AccountManagementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(AccountManagementMenus.Prefix, displayName: "AccountManagement", "~/AccountManagement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
