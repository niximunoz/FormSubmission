using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
    [HttpPost("submit")]
    public IActionResult Submit(User user)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpGet("success")]
    public ViewResult Success()
    {
        return View("Success");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
