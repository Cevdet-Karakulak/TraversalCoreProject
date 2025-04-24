using BusinnessLayer.Abstract;
using BusinnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService1 _destinationService;

        public DestinationController(IDestinationService1 destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            var vallues = _destinationService.TGetList();
            return View(vallues);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination1 destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination1 destination)
        {
            if (ModelState.IsValid) // Modelin geçerli olup olmadığını kontrol et
            {
                _destinationService.TUpdate(destination); // Güncelleme işlemi
                return RedirectToAction("Index");
            }

            // Eğer model geçerli değilse, hatayı göstermek için aynı view'ı tekrar render et
            return View(destination);
        }
    }
}
