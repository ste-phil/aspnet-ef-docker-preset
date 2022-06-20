using HomeApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeApp.Server.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> logger;
    public readonly IRepositoryService repo;


    public IndexModel(ILogger<IndexModel> logger, IRepositoryService repo)
    {
        this.logger = logger;
        this.repo = repo;
    }
}
