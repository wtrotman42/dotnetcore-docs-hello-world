using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcoresample.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private readonly IConfiguration _config;

    public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    public void OnGet()
    {
        ViewData["Name"] = _config["Name"];
    }
}

