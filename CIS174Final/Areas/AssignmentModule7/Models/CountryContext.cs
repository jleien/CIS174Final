using Microsoft.EntityFrameworkCore;

namespace CIS174Final.Areas.AssignmentModule7.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country>? Countries { get; set; }
        public DbSet<Game>? Games { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "para", Name = "Paralympics" },
                new Game { GameID = "youth", Name = "Youth Olympics" }
                );

            modelBuilder.Entity<Country>().HasData(
                new {CountryID = "can", Name = "Canada", GameID = "winter", CategoryID = "indoor", FlagImage = "ca.png"},
                new { CountryID = "swe", Name = "Sweden", GameID = "winter", CategoryID = "indoor", FlagImage = "se.png" },
                new { CountryID = "gbe", Name = "Great Britain", GameID = "winter", CategoryID = "indoor", FlagImage = "gb.png" },

                new { CountryID = "jam", Name = "Jamaica", GameID = "winter", CategoryID = "outdoor", FlagImage = "jm.png" },
                new { CountryID = "ita", Name = "Italy", GameID = "winter", CategoryID = "outdoor", FlagImage = "it.png" },
                new { CountryID = "jap", Name = "Japan", GameID = "winter", CategoryID = "outdoor", FlagImage = "jp.png" },

                new { CountryID = "ger", Name = "Germany", GameID = "summer", CategoryID = "indoor", FlagImage = "de.png" },
                new { CountryID = "chi", Name = "Germany", GameID = "summer", CategoryID = "indoor", FlagImage = "cn.png" },
                new { CountryID = "mex", Name = "Germany", GameID = "summer", CategoryID = "indoor", FlagImage = "mx.png" },

                new { CountryID = "brz", Name = "Brazil", GameID = "summer", CategoryID = "outdoor", FlagImage = "br.png" },
                new { CountryID = "ndr", Name = "Netherlands", GameID = "summer", CategoryID = "outdoor", FlagImage = "nl.png" },
                new { CountryID = "usa", Name = "United States", GameID = "summer", CategoryID = "outdoor", FlagImage = "us.png" },

                new { CountryID = "tha", Name = "Thailand", GameID = "para", CategoryID = "indoor", FlagImage = "th.png" },
                new { CountryID = "uru", Name = "Uruguay", GameID = "para", CategoryID = "indoor", FlagImage = "uy.png" },
                new { CountryID = "ukr", Name = "Ukraine", GameID = "para", CategoryID = "indoor", FlagImage = "ua.png" },

                new { CountryID = "aus", Name = "Austria", GameID = "para", CategoryID = "outdoor", FlagImage = "at.png" },
                new { CountryID = "pak", Name = "Pakistan", GameID = "para", CategoryID = "outdoor", FlagImage = "pk.png" },
                new { CountryID = "zim", Name = "Zimbabwe", GameID = "para", CategoryID = "outdoor", FlagImage = "zw.png" },

                new { CountryID = "fra", Name = "France", GameID = "youth", CategoryID = "indoor", FlagImage = "fr.png" },
                new { CountryID = "cyp", Name = "Cyprus", GameID = "youth", CategoryID = "indoor", FlagImage = "cy.png" },
                new { CountryID = "rus", Name = "Russia", GameID = "youth", CategoryID = "indoor", FlagImage = "ru.png" },

                new { CountryID = "fin", Name = "Finland", GameID = "youth", CategoryID = "outdoor", FlagImage = "fi.png" },
                new { CountryID = "slv", Name = "Slovakia", GameID = "youth", CategoryID = "outdoor", FlagImage = "sk.png" },
                new { CountryID = "por", Name = "Portugal", GameID = "youth", CategoryID = "outdoor", FlagImage = "pt.png" }
                );
        }
    }
}
