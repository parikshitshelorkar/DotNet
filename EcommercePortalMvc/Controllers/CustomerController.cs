using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommercePortalMvc.Models;

namespace EcommercePortalMvc.Controllers;
class CustomerController: Controller
{
    public IActionResult ShowCustomerDetail()
    {
        return View();
    }
    public IActionResult AddCustomer()
    {
        return View();
    }
    public IActionResult DeleteCustomer()
    {
        return View();
    }
    
}