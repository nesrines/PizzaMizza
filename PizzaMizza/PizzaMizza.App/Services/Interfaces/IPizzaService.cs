namespace PizzaMizza.App.Services.Interfaces
{
    internal interface IPizzaService
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task ShowById(int id);
        public Task ShowAll();
    }
}
