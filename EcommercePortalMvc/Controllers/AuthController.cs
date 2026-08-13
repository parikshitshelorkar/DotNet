using Microsoft.AspNetCore.Mvc;
using ECommercePortalMvc.Models;

namespace ECommercePortalMvc.Controllers;

public class AuthController : Controller
{
    // [HttpGet]                //This is not getting called due to partial view implementation

    // public IActionResult Login()
    // {
    //     Credential credential = new Credential();
    //     credential.UserName= "";
    //     credential.Password="";
    //     return PartialView("_Login", credential);
    // }
    [HttpPost]
    public IActionResult Login(Credential credential)
    {
        if(credential.UserName=="admin" && credential.Password == "transflower")
        {
            return RedirectToAction("welcome", "Home");
        }
        else
        {
            return View("Index", "Auth");
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        Customer customer = new Customer();
        customer.Id=1;
        customer.Name="";
        customer.Email="";
        customer.Contact="";
        return PartialView("_Register",customer);
    }
    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        Console.WriteLine($"New user Registered: {customer.Name}, {customer.Email}, {customer.Contact}");
        return  RedirectToAction("Index");
    }

    public IActionResult ChangePassword()
    {
        return PartialView("_ChangePassword");
    }
    public IActionResult Index()
    {
        return View();
    }
}
