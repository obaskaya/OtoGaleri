using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtoGaleri.Data;
using OtoGaleri.Models;

namespace OtoGaleri.Controllers;

public class CarController : Controller
{
    private readonly CarData _carData;

    [ActivatorUtilitiesConstructor]
    public CarController(CarData carData)
    {
        _carData = carData;
    }
    
    // GET
    public IActionResult Index(string id)
    {
        if (id != null)
        {
            var carList = _carData.carData.Where(x => x.CarBrand == id)
                .ToList();
            return View(carList);
        }
        else
        {
            return View(_carData.carData);
        }
    }
    
    [HttpGet]
    public IActionResult BuyCar(string id)
    {
        var findCar = _carData.carData.Where(x => x.CarID == int.Parse(id)).FirstOrDefault();
        _carData.carData.Remove(findCar);
        
        TempData["message"] = "Tebrikler aracımızı satın aldınız!";
        return RedirectToAction("Index");
    }

    
    [HttpGet]
    public IActionResult AddCar()
    {
        return View("AddCar");
    }

    [HttpPost]
    public async Task<IActionResult> AddCar(Car car, IFormFile uploadPhoto)
    {
        if (uploadPhoto != null)
        {
            string wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            string fileName = Path.GetFileNameWithoutExtension(uploadPhoto.FileName);
            string extension = Path.GetExtension(uploadPhoto.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            car.CarImage = fileName;
            string path = Path.Combine(wwwRootPath + "/Assets/assets/carimg", fileName);
            using (var fileStream = new FileStream(path,FileMode.Create))
            {
                await uploadPhoto.CopyToAsync(fileStream);
            }
        }
        
        Random rnd = new Random();
        car.CarID = rnd.Next();;
        car.CarDescription = "test";
        
        _carData.carData.Add(car);
        TempData["message"] = "Araç başarıyla eklendi.";
        return RedirectToAction("Index");
    }
}