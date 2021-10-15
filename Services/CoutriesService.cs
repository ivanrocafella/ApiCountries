using ApiCountries.Interfaces;
using ApiCountries.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCountries.Services
{
    public class CoutriesService : ICountryService
    {
        private readonly CountriesContext _context;

        public CoutriesService(CountriesContext context)
        {
            _context = context;
        }

        public async Task<bool> Any(int id) => await _context.Countries.AnyAsync(x => x.ID == id);

        public async Task Delete(Country o)
        {
            _context.Countries.Remove(o);
            await _context.SaveChangesAsync();
        }

        public async Task<Country> Get(int id)
        {
            Country country = await _context.Countries.FirstOrDefaultAsync(e => e.ID == id);
            return country;
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            IEnumerable<Country> countries = await _context.Countries.ToListAsync();
            return countries;
        }

        public async Task<Country> Post(Country o)
        {
            _context.Countries.Add(o);
            await _context.SaveChangesAsync();
            return o;
        }

        public async Task<Country> Put(Country o)
        {
            _context.Countries.Update(o);
            await _context.SaveChangesAsync();
            return o;
        }
    }
}
