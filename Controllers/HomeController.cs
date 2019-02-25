using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PetShop.Dal;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Pet> _repoPet;        // real repository 
        private IMockRepository _repoMock;   // fake repository for demo

        public HomeController(IRepository<Pet> repoPet, IMockRepository repoMock)
        {
            // this Generic Repository of Pets should be used in real scondtions with a valid db connection
            _repoPet = repoPet;
            // for the demo purpose we will use a fake repository where data population is hard coded    (*)  
            _repoMock = repoMock;
        }

        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult FillCombo()
        {
           var pets = _repoMock.GetAll().ToList();
            return Json(pets);
        }


        public IActionResult About()
        {
            return View();
        }      
    }
}
