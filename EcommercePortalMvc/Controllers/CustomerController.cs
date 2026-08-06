using Microsoft.AspNetCore.Mvc;
using EcommercePortalMvc.Models;

namespace ECommercePortal.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Aboutus()
    {
        string content = "Doing ordinary Things Extraordinarily well is the key to success";
        ViewData["Message"] = content;

        return View();
    }
    public IActionResult Contactus()
    {
        Address address = new Address
        {
            Street = "601, Pune Satar Road",
            City = "Pune",
            State = "MH",
            ZipCode = "41009"
        };
        ViewData["Address"] = address;
        return View();
    }

}