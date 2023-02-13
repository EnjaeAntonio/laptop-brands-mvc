using Microsoft.AspNetCore.Mvc.Rendering;
using MVCAssessment.Data;

namespace MVCAssessment.Models
{
    public class Brand
    {
        private readonly int _brandId;
        public int BrandId { get { return _brandId; } }
        private string _name;
        public string Name { get { return _name; } }
        public HashSet<Laptop> Laptops { get; set; }

        public Brand(string name)
        {
            _brandId = Context.GetIdCount();
            _name = name;
            Laptops = new HashSet<Laptop>();
        }
    }
}
