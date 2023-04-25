using PizzaMizza.Core.Models.BaseModels;
using PizzaMizza.Core.Models.Enums;

namespace PizzaMizza.Core.Models
{
    public class Pizza:BaseModel
    {
        private static int _id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public Pizza(string Name, string Ingredients, PizzaSize Size, double Price)
        {
            _id++;
            Id = _id;
            this.Name = Name;
            this.Ingredients = Ingredients;
            this.Size = Size;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
//medium = x, small = 0.75x, large = 1.25x