using Microsoft.AspNetCore.Mvc;
using MVCAssessment.Models;
using MVCAssessment.Data;
using MVCAssessment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCAssessment.Controllers
{
    public class LaptopsController : Controller
    {
        public IActionResult Index()
        {
            return View(Context.Laptops);
        }

        public IActionResult Details(int id)
        {
            Laptop laptop = Context.Laptops.FirstOrDefault(l => l.id == id);

            if (laptop == null)
            {
                return NotFound();
            }
            return View(laptop);
        }
        public IActionResult MostExpensive()
        {
             List<Laptop> laptops = Context.Laptops.OrderByDescending(l => l.price).Take(2).ToList();
            return View(laptops);
        }

        public IActionResult MostCheapest()
        {
            List<Laptop> laptops = Context.Laptops.OrderBy(l => l.price).Take(3).ToList();
            return View(laptops);
        }

        public IActionResult LaptopsByType()
        {
            List<Laptop> Newlaptops = Context.Laptops.Where(l => l.Type == "New").ToList();
            List<Laptop> Refurblaptops = Context.Laptops.Where(l => l.Type == "Refurbished").ToList();
            List<Laptop> Rentedlaptops = Context.Laptops.Where(l => l.Type == "Rental").ToList();

            LaptopsTypeViewModel model = new LaptopsTypeViewModel
            {
                NewLaptops = Newlaptops,
                RefurbishedLaptops = Refurblaptops,
                RentalLaptops = Rentedlaptops
            };

            return View(model);
        }

        public IActionResult LaptopsByBudget(int budget)
        {
            List<Laptop> laptops = Context.Laptops.Where(l => l.price <= budget).ToList();
            return View(laptops);
        }

        [HttpGet]

        public IActionResult CompareLaptops()
        {
            IEnumerable<SelectListItem> LaptopLists = Context.Laptops.Select(l => new SelectListItem
            {
                Text = l.ModelName,
                Value = l.id.ToString()
            });

            CompareLaptopsViewModel model = new CompareLaptopsViewModel
            {
                LaptopLists = LaptopLists,
            };

            return View(model);
        }

        [HttpPost]

        public IActionResult CompareLaptops(int laptop1Id, int laptop2Id)
        {
            Laptop laptop1 = Context.Laptops.FirstOrDefault(l => l.id == laptop1Id);
            Laptop laptop2 = Context.Laptops.FirstOrDefault(l => l.id == laptop2Id);

            if (laptop1 == null || laptop2 == null)
            {
                return NotFound();
            }

            CompareLaptopsViewModel model = new CompareLaptopsViewModel
            {
                laptop1 = laptop1,
                laptop2 = laptop2
            };
            return View(model);
        }

        public IActionResult FilterLaptops(int minYear, int maxYear, int minPrice, int maxPrice)
        {
            int currentYear = DateTime.Now.Year;
            if (minYear < 2000 || minYear > currentYear)
            {
                minYear = 2000;
            }

            if (maxYear < minYear || maxYear > currentYear)
            {
                maxYear = currentYear;
            }

            if (minPrice < 0)
            {
                minPrice = 0;
            }

            List<Laptop> laptops = Context.Laptops
                .Where(l => l.ReleaseDate.Year >= minYear && l.ReleaseDate.Year <= maxYear)
                .Where(l => l.price >= minPrice && l.price <= maxPrice).ToList();

            return View(laptops);
        }

        public IActionResult BrandsIndex()
        {
            return View(Context.Brands);
        }

        [HttpGet]
        public IActionResult AddLaptop()
        {
            List<SelectListItem> brands = Context.Brands.Select(b => new SelectListItem
            {
                Value = b.BrandId.ToString(),
                Text = b.Name
            }).ToList();

            AddLaptopViewModel model = new AddLaptopViewModel
            {
                Brands = brands
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult AddLaptop(AddLaptopViewModel model)
        {
            Brand brand = Context.Brands.FirstOrDefault(b => b.BrandId == model.BrandId);
            if (brand == null)
            {
                return NotFound();
            }
            if (model == null)
            {
                return View(model);
            }

            Laptop laptop = new Laptop
            {
                ModelName = model.Name,
                Brand = brand,
                ReleaseDate = DateTime.Now,
                price = model.Price,
                Type = model.Type,
            };


            Context.Laptops.Add(laptop);

            return RedirectToAction("Index");
        }
    }
}
