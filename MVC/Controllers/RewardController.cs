using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;
public class RewardController : Controller
{
    private readonly ILogger<RewardController> _logger;

    public RewardController(ILogger<RewardController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
