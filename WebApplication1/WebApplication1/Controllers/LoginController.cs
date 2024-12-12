using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    [HttpGet]
    [Route("login")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("login")]
    public IActionResult Index(string username, string password)
    {
        // Add authentication logic here
        if (username == "admin" && password == "password")
        {
            return RedirectToAction("Index", "Home");
        }

        ViewBag.ErrorMessage = "Invalid username or password.";
        return View();
    }
}
