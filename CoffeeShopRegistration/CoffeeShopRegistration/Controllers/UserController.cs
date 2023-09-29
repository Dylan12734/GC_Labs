using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers;

public class UserController : Controller
{
    private readonly AppDbContext _appDpContext;
    public UserController(AppDbContext appDpContext)
    {
        _appDpContext = appDpContext;
    }
    public IActionResult Index()
    {
        User user = new User();
        return View();
    }
    [HttpPost]

    public IActionResult ProcessUserForm([FromForm] User newUser)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }
        _appDpContext.Users.Add( newUser);
        _appDpContext.SaveChanges();

        return RedirectToAction("Index", "Home");
    }
}
