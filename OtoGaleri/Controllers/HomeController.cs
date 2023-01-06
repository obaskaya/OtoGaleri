using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtoGaleri.Data;
using OtoGaleri.Models;

namespace OtoGaleri.Controllers;

public class HomeController : Controller
{
    private readonly CarData _carData;

    public HomeController(CarData carData)
    {
        _carData = carData;
    }
    public IActionResult Index()
    {
        var carBrands = _carData.carData
            .Select(x => x.CarBrand)
            .Distinct();
        
        return View(carBrands);
    }
}