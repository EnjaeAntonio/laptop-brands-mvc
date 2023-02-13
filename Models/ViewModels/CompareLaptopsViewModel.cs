using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCAssessment.Models.ViewModels
{
    public class CompareLaptopsViewModel
    {
        public IEnumerable<SelectListItem> LaptopLists { get; set; }
        public Laptop laptop1 { get; set; }
        public Laptop laptop2 { get; set;  }
    }
}
