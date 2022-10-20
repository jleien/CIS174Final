using CIS174Final.Areas.AssignmentModule7.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174Final.Areas.AssignmentModule7.Controllers
{
    public class FavoritesController : Controller
    {
        [Area("AssignmentModule7")]
        [Route("/Favorites")]
        [HttpGet]
        public ViewResult Index()
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat(),
                Countries = session.GetMyCountries()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new CountrySession(HttpContext.Session);
            var cookies = new CountryCookies(Response.Cookies);

            session.RemoveMyCountries();
            cookies.RemoveMyCountryIds();

            TempData["message"] = "Favorite countries cleared";

            return RedirectToAction("Index", "AssignmentModule7",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}
