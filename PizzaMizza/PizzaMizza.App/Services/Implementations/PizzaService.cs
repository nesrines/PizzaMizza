using PizzaMizza.App.Services.Interfaces;
using PizzaMizza.Core.Models;
using PizzaMizza.Core.Models.Enums;
using PizzaMizza.Data.Repositories;
using System.Reflection;

namespace PizzaMizza.App.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        PizzaRepository pizzaRepository = new PizzaRepository();
        public async Task Create()
        {
            Console.WriteLine("Enter the name:");
            string Name = Console.ReadLine().Trim();
            while (string.IsNullOrWhiteSpace(Name) || Name.Length < 5)
            {
                Console.WriteLine("Enter the name again:");
                Name = Console.ReadLine().Trim();
            }

            Console.WriteLine("Enter the size:");
            Console.WriteLine("1 for Small; 2 for Medium; 3 for Large");
            
            int.TryParse(Console.ReadLine().Trim(), out int SizeIndex);

            bool result = Enum.IsDefined(typeof(Enum), SizeIndex);
            while(!result)
            {
                Console.WriteLine("Enter a valid size:");
                int.TryParse(Console.ReadLine().Trim(), out SizeIndex);

            }
            double IngredientsPrice = 0;
            PizzaSize Size = (PizzaSize)SizeIndex;
            double Price;
            if (Size == (PizzaSize)1)
            { Price = IngredientsPrice * 0.75; }
            else if(Size == (PizzaSize)2)
            { Price = IngredientsPrice; }
            else { Price = IngredientsPrice * 1.25; }
            
            pizzaRepository.CreateAsync(new Pizza(Name, "", Size, Price));
        }
        public async Task Update()
        {

        }

        public async Task Delete()
        {

        }

        public async Task ShowAll()
        {

        }

        public async Task ShowById(int id)
        {

        }
    }
}
