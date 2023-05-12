using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class ChallengeController : Controller
{
    private readonly ILogger<ChallengeController> _logger;

    public ChallengeController(ILogger<ChallengeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index(UserViewModel userViewModel)
    {
        //test bara
        userViewModel.AvailableChallenges = new List<CORE.Entities.Challenge>()
        {
            new CORE.Entities.Challenge { challenge_name = "Kransmossen", challenge_level = 1 }
        };

        return View(userViewModel);
    }

    public async Task<IActionResult> Start(CORE.Entities.Challenge challenge)
    {
        challenge = new CORE.Entities.Challenge()
        {
            challenge_name = "Hinderbana!",
            description = "Kan du ta dig runt hinderbanan på 15 min?"
        };

        return View(challenge);
    }
}
