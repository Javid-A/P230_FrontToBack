using Microsoft.AspNetCore.Mvc;
using P230_FrontToBack.Entities;

namespace P230_FrontToBack.Controllers
{
    public class HomeController:Controller
    {
        readonly List<Service> _services;
        public HomeController()
        {
            _services = new List<Service>()
            {
                new Service()
                {
                    Id= 1,
                    Title = "Asperiores Test",
                    Desc = "Non et temporibus minus omnis sed dolor esse consequatur. Cupiditate sed error ea fuga sit provident adipisci neque.",
                    Image = "services-4.jpg",
                    Icon = "bi bi-bounding-box-circles"
                },
                 new Service()
                {
                    Id= 2,
                    Title = "Asperiores Albert",
                    Desc = "Non et temporibus minus omnis sed dolor esse consequatur. Cupiditate sed error ea fuga sit provident adipisci neque.",
                    Image = "services-5.jpg",
                    Icon = "bi bi-activity"
                },
                  new Service()
                {
                    Id= 3,
                    Title = "Asperiores Commodit",
                    Desc = "Non et temporibus minus omnis sed dolor esse consequatur. Cupiditate sed error ea fuga sit provident adipisci neque.",
                    Image = "services-6.jpg",
                    Icon = "bi bi-easel"
                },
                    new Service()
                {
                    Id= 4,
                    Title = "New Albert Service about Pink Section",
                    Desc = "Non et temporibus minus omnis sed dolor esse consequatur. Cupiditate sed error ea fuga sit provident adipisci neque.",
                    Image = "services-3.jpg",
                    Icon = "bi bi-easel"
                }
            };
        }
        public IActionResult Index()
        {
            return View(_services);
        }
    }
}
