using BusinnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
        [Area("Member")]
        public class LastDestinationsController : Controller
        {
            private readonly IDestinationService1 _destinationService;
            public LastDestinationsController(IDestinationService1 destinationService)
            {
                _destinationService = destinationService;
            }
            public IActionResult Index()
            {
                var values = _destinationService.TGetLast4Destinations();
                return View(values);
            }
        }
    }
