using Adoption_MVC_Lab.Models;
using Adoption_MVC_Lab.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Adoption_MVC_Lab.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public AnimalController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string? searchterm)
        {
            if(searchterm!= null)
            {
                return View(_appDbContext.Animals.Where(x => x.Breed.ToLower().Trim().Contains(searchterm.ToLower())).ToList());
            }
            List<Animal> animals = _appDbContext.Animals.OrderBy(x=> x.Name).ToList();
            return View(animals);
        }

        
        
        public IActionResult AddAnimal(Animal animal)
        {
            animal= new Animal();
            return View(animal);
        }
        [HttpPost]
        public IActionResult ProcessAnimalForm([FromForm] Animal newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddAnimal");
            }
            _appDbContext.Animals.Add(newAnimal);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AdoptAnimal(int id)
        {
            var animal = _appDbContext.Animals.FirstOrDefault(x=> x.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            _appDbContext.Animals.Remove(animal);
            _appDbContext.SaveChanges(true);
            return RedirectToAction("Index");

        }
    }
}
