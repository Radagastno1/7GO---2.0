using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using CORE.Interfaces;

namespace MVC.Controllers;

public class BecomeMemberController : Controller
{
    private readonly ILogger<BecomeMemberController> _logger;

    public BecomeMemberController(ILogger<BecomeMemberController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}