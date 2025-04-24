using BusinnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class DestinationController : Controller
    {
        DestinationManager1 destinationManager = new DestinationManager1(new EfDestinationDal1());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

    }
}
