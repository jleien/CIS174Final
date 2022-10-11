namespace CIS174Final.Areas.AssignmentModule7.Models
{
    public class Country
    {
        public string CountryID { get; set; }   
        public string Name { get; set; }
        public Category Category { get; set; }  
        public Game Game { get; set; }
        public string FlagImage { get; set; }
    }
}
