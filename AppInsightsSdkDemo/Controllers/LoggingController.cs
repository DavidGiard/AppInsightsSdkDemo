using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppInsightsSdkDemo.Models;

namespace AppInsightsSdkDemo.Controllers;

public class LoggingController : Controller
{
    private readonly ILogger<LoggingController> _logger;

    public LoggingController(ILogger<LoggingController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult LogInformation()
    {
        var msg = "This is an information message";
        LoggedInfo logInfo = new LoggedInfo("Information", msg);
        ViewBag.Message = logInfo;
        _logger.LogInformation(msg);
        return View("Index");
    }
    public IActionResult LogTrace()
    {
        var msg = "This is an trace message";
        LoggedInfo logInfo = new LoggedInfo("Trace", msg);
        ViewBag.Message = logInfo;
        _logger.LogTrace(msg);
        return View("Index");
    }
    
    public IActionResult LogWarning()
    {
        var msg = "This is a warning message";
        LoggedInfo logInfo = new LoggedInfo("Warning", msg);
        ViewBag.Message = logInfo;
        _logger.LogWarning(msg);
        return View("Index");
    }

    public IActionResult LogError()
    {
        var msg = "This is an error message";
        LoggedInfo logInfo = new LoggedInfo("Error", msg);
        ViewBag.Message = logInfo;
        _logger.LogError(msg);
        return View("Index");
    }

    public IActionResult LogCritical()
    {
        var msg = "This is a critical message";
        LoggedInfo logInfo = new LoggedInfo("Critical", msg);
        ViewBag.Message = logInfo;
        _logger.LogInformation(msg);
        return View("Index");
    }

}

