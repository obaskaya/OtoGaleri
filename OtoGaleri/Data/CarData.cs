using System.Collections.Generic;
using OtoGaleri.Models;

namespace OtoGaleri.Data;

public class CarData
{
    public List<Car> carData = new List<Car>
    {
    new Car(){CarID = 1, CarBrand = "BMW", CarModel = "2.18i", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2020, CarKm = 120f, CarPrice = 1249500f},
    new Car(){CarID = 2, CarBrand = "BMW", CarModel = "7.30i Long", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2019, CarKm = 453f, CarPrice = 1049240f},
    new Car(){CarID = 3, CarBrand = "BMW", CarModel = "3.20i", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2022, CarKm = 5000f, CarPrice = 1234362f},
    new Car(){CarID = 4, CarBrand = "Porsche", CarModel = "Cayenne", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2019, CarKm = 50000f, CarPrice = 2357394f},
    new Car(){CarID = 5, CarBrand = "Porsche", CarModel = "Panemera", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2017, CarKm = 85399f, CarPrice = 8950000f},
    new Car(){CarID = 6, CarBrand = "Porsche", CarModel = "Taycane", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2018, CarKm = 1250f, CarPrice = 5400000f},
    new Car(){CarID = 7, CarBrand = "Mercedes", CarModel = "AMG", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2020, CarKm = 5000f, CarPrice = 1665000f},
    new Car(){CarID = 8, CarBrand = "Audi", CarModel = "Q7", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2021, CarKm = 400f, CarPrice = 4500000f},
    new Car(){CarID = 9, CarBrand = "Audi", CarModel = "A8", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2022, CarKm = 500f, CarPrice = 6500000f},
    new Car(){CarID = 10, CarBrand = "Lamborghini", CarModel = "Gallardo", CarDescription = "test", CarImage = "lthmb_9850391031lc224901135.jpg", CarYear = 2019, CarKm = 800f, CarPrice = 6100000f},
    };
}