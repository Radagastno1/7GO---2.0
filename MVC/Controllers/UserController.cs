using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using CORE.Interfaces;

namespace MVC.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly Iservice<CORE.Entities.User> _userService;

    public UserController(ILogger<UserController> logger, Iservice<CORE.Entities.User> userService)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> LogIn(UserViewModel userViewModel)
    {
        var user = new CORE.Entities.User { user_inlog = userViewModel.UserInlog };

        var loggedInUser = await _userService.add(user); //här får vi vilka utmaningear som personen har gjort och ej

        userViewModel = new UserViewModel
        {
            Id = loggedInUser.userId,
            Name = loggedInUser.user_name,
            AvailableChallenges = loggedInUser.challenges.ToList() //här hämta bara de som EJ är gjorda sen
        };

        return RedirectToAction("Index", "Challenge", userViewModel);
    }
    public async Task<IActionResult> BecomeMember()
    {
        var userViewModel = new UserViewModel();
        return View(userViewModel);
    }
    public async Task<IActionResult> PostMember(UserViewModel userViewModel)
    {
        var user = new CORE.Entities.User()
        {
            user_name = userViewModel.Name
        };
        var loggedInUser = await _userService.add(user); //här får vi vilka utmaningear som personen har gjort och ej

        return RedirectToAction("Index", "Challenge", userViewModel);
    }
}
