using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRapp.Models;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Signup()
    {
        return View();
    }
}