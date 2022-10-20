using CIS174Final.Areas.AssignmentModule7.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174Final.Areas.AssignmentModule7.Controllers
{
    [Area("AssignmentModule7")]

    public class CountryController : Controller
    {
        private CountryContext context;

        public CountryController(CountryContext ctx)
        {
            context = ctx;
        }

        [Route("/AssignmentModule7")]
        public IActionResult Index(string activeCat = "all", string activeGame = "all")
        {
            var session = new CountrySession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveCat(activeCat);
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new CountryCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(c => c.Game)
                        .Include(c => c.Category)
                        .Where(c => ids.Contains(c.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }

            var data = new CountryListViewModel
            {
                ActiveCat = activeCat,
                ActiveGame = activeGame,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCat.ToLower());
            if (activeGame != "all")
                query = query.Where(
                    t => t.Game.GameID.ToLower() == activeGame.ToLower());
            data.Countries = query.ToList();

            return View(data);
        }

        [Route("/AssignmentModule7/Details/{id?}")]
        public IActionResult Details(string id)
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(c => c.Game)
                    .Include(c => c.Category)
                    .FirstOrDefault(c => c.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveGame()
            };
            return View(model);
        }
        [HttpPost]
        [Route("/AssignmentModule7")]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Category)
                .Where(c => c.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new CountrySession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            var cookies = new CountryCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }


    }
}
