using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AccountManagement.Pages;

public class IndexModel : AccountManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
