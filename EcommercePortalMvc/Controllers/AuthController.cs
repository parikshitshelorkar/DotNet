using Microsoft.AspNetCore.Mvc;
using EcommercePortalMvc.Models;
using ECommercePortal.Models;
namespace EcommercePortalMvc.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        Credential credential = new Credential();
        credential.UserName= "";
        credential.Password="";
        return View(credential);
    }
    [HttpPost]
    public IActionResult Login(Credential credential)
    {
        if(credential.UserName=="admin" && credential.Password == "transflower")
        {
            return RedirectToAction("Welcome", "Home");
        }
        else
        {
            return View();
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
        return View(customer);
    }
    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        Console.WriteLine($"New user Registered: {customer.Name}, {customer.Email}, {customer.Contact}");
        return  RedirectToAction("Login");
    }

    public IActionResult ChangePassword()
    {
        return View();
    }
}

    
