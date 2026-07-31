using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;

namespace MvcWebApp.Controllers;

public class CustomerController: Controller
{
    //Action methods:
    
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ShowCustomerDetails()
    {
        return View();
    }
}