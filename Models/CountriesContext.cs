using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCountries.Models
{
    public class CountriesContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public CountriesContext(DbContextOptions<CountriesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country[]
                {
                new Country { ID=1, Name="Tunisia", Area=163610, Capital="Tunis", Flag="https://flagcdn.com/tn.svg", Region="Africa"},
                new Country { ID=2, Name="Denmark", Area=43094, Capital="Copenhagen", Flag="https://flagcdn.com/dk.svg", Region="Europe"},
                new Country { ID=3, Name="Chile", Area=756102, Capital="Santiago", Flag="https://flagcdn.com/cl.svg", Region="Americas"},
                new Country { ID=4, Name="Macau", Area=30, Flag="https://flagcdn.com/mo.svg", Region="Asia"},
                new Country { ID=5, Name="Armenia", Area=29743, Capital="Yerevan", Flag="https://flagcdn.com/am.svg", Region="Asia"},
                new Country { ID=6, Name="Palau", Area=459, Capital="Ngerulmud", Flag="https://flagcdn.com/pw.svg", Region="Oceania"},
                new Country { ID=7, Name="Estonia", Area=45227, Capital="Tallinn", Flag="https://flagcdn.com/ee.svg", Region="Europe"},
                new Country { ID=8, Name="Iraq", Area=438317, Capital="Baghdad", Flag="https://flagcdn.com/iq.svg", Region="Asia"},
                new Country { ID=9, Name="Taiwan", Area=36193, Capital="Taipei", Flag="https://flagcdn.com/tw.svg", Region="Asia"},
                new Country { ID=10, Name="Bosnia and Herzegovina", Area=51209, Capital="Sarajevo", Flag="https://flagcdn.com/ba.svg", Region="Europe"},
                });
        }
    }
}
