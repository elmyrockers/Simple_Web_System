using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


public class UsersController : Controller
{
    private readonly UserRepository _userRepository;

    public UsersController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IActionResult Index()
    {
        var users = _userRepository.GetAllUsers();
        // d( users );
        
        return View( users ); // If using views
        // return Json(users); // If returning JSON data
    }
}