using PizzaMizza.Core.Models.BaseModels;
using PizzaMizza.Core.Models.Enums;

namespace PizzaMizza.Core.Models
{
    public class Pizza:BaseModel
    {
        public string Name { get; set; }
        public  PizzaSize Size { get; set; }
        public double Price { get; set; }
        private static int _id;
        public Pizza(string Name, PizzaSize Size, double Price)
        {
            this.Name = Name;
            this.Size = Size;
            this.Price = Price;
            _id++;
            Id = _id;
        }
    }
}
