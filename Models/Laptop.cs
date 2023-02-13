using System.Runtime.CompilerServices;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MVCAssessment.Data;

namespace MVCAssessment.Models
{
    public class Laptop
    {
        public int id { get; set; }
        public string ModelName;
        public Brand Brand { get; set; }
        public int price { get; set; }
        public DateTime ReleaseDate { get; set; }
        private int _quantity { get; set; }
        public int Quantity 
        { 
            get { return _quantity; } 
            set
            {
                if(_quantity <= 0)
                {
                    throw new Exception("This product is out of stock");
                } else
                {
                    _quantity = value;
                }
            }
        }
        public string Type { get; set; }

        public Laptop()
        {

        }
        public Laptop(string modelName, Brand Brand, int Price, int quantity, DateTime ReleaseDate, string type)
        {
            id = Context.GetIdCount();
            ModelName = modelName;
            _quantity = quantity;
            Type = type;
            price = Price;
        }
    }
}
