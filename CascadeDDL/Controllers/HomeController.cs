using CascadeDDL.context;
using CascadeDDL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;


namespace CascadeDDL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CascadeDbContext _cascadeDbContext;

        public HomeController(ILogger<HomeController> logger, CascadeDbContext cascadeDbContext)
        {
            _logger = logger;
            _cascadeDbContext = cascadeDbContext;
        }

        public ActionResult Index()
        {
            List<Country> CountryList = _cascadeDbContext.Countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "Id", "CountryName");
            return View();
        }

        public JsonResult GetCityList(int CountryId)
        {
            List<City> StateList = _cascadeDbContext.Cities
                .Where(x => x.CountryId == CountryId).ToList();
            return Json(StateList);

        }
    }
}