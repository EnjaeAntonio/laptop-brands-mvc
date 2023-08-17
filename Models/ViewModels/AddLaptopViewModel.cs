using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCAssessment.Models.ViewModels
{
    public class AddLaptopViewModel
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public IEnumerable<SelectListItem> Brands { get; set; }
    }
}
