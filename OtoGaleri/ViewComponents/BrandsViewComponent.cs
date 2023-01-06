using Microsoft.AspNetCore.Mvc;
using OtoGaleri.Data;

namespace OtoGaleri.ViewComponents;

public class BrandsViewComponent : ViewComponent
{
    
    private readonly CarData _carData;

    [ActivatorUtilitiesConstructor]
    public BrandsViewComponent(CarData carData)
    {
        _carData = carData;
    }
    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var carBrands = _carData.carData
            .Select(x => x.CarBrand)
            .Distinct();
        
        RouteData.Values.Remove("id");
        return View("Index",carBrands);
    }
    
}