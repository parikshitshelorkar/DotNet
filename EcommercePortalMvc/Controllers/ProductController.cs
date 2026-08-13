using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommercePortalMvc.Models;

namespace ECommercePortalMvc.Controllers;

public class ProductController : Controller
{
    private static List<Product> products = new List<Product>()
    {
        new Product { Id = 101, Name = "Laptop", Price = 55000 },
            new Product { Id = 102, Name = "Mobile", Price = 25000 },
            new Product { Id = 103, Name = "Keyboard", Price = 1200 },
            new Product { Id = 104, Name = "Mouse", Price = 800 },
            new Product { Id = 105, Name = "Monitor", Price = 9000 }
    };

    public IActionResult Index()
    {
        return View(products);
    }
    public IActionResult List()
    {
        return View(products);
    }

    public IActionResult Details(int id)
    {
        Product product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Product product)
    {
        products.Add(product);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Product product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }
    [HttpPost]
    public IActionResult Update(Product product)
    {
        Product existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
        }
        return RedirectToAction("List");

    }
    [HttpGet]
    public IActionResult Remove(int id)
    {
        Product product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        
    }
    [HttpPost]
    public IActionResult Remove(Product product)
    {
        Product existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            products.Remove(existingProduct);
        }
        return RedirectToAction("List");
    }
}

