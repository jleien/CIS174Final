namespace CIS174Final.Areas.AssignmentModule7.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0,
                    new Category { CategoryID = "all", Name = "All" });
            }
        }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game { GameID = "all", Name = "All" });
            }
        }

        public string CheckActiveCat(string c) =>
            c.ToLower() == ActiveCat.ToLower() ? "active" : "";
        
        public string CheckActiveGame(string d) =>
            d.ToLower() == ActiveGame.ToLower() ? "active" : "";


    }
}
