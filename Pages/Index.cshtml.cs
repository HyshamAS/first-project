using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstProject.Pages;

public class IndexModel : PageModel
{
    public string ServerTime { get; private set; } = string.Empty;

    public void OnGet()
    {
        ServerTime = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss");
    }
}
