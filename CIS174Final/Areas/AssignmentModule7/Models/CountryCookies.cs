namespace CIS174Final.Areas.AssignmentModule7.Models
{
    public class CountryCookies
    {
        private const string CountriesKey = "mycountries";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }
        public CountryCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public CountryCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIds(List<Country> mycountries)
        {
            List<string> ids = mycountries.Select(c => c.CountryID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyCountryIds();     // delete old cookie first
            responseCookies.Append(CountriesKey, idsString, options);
        }

        public string[] GetMyCountryIds()
        {
            string cookie = requestCookies[CountriesKey];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };   // empty string array
            else
                return cookie.Split(Delimiter);
        }

        public void RemoveMyCountryIds()
        {
            responseCookies.Delete(CountriesKey);
        }
    }
}
