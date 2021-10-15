using ApiCountries.Interfaces;
using ApiCountries.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCountries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService service;

        public CountriesController(ICountryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetAll()
        {
            IEnumerable<Country> countries = await service.GetAll();
            return countries.ToList();
        }

        // GET api/users/get/5
        [HttpGet]
        [Route("get/{id}")]
        public async Task<ActionResult<Country>> Get(int id)
        {
            Country country = await service.Get(id);
            if (country == null)
                return NotFound();
            return new ObjectResult(country);
        }

        // POST api/countries
        [HttpPost]
        public async Task<ActionResult<Country>> Post(Country country)
        {
            if (country == null)
                return BadRequest();
            await service.Post(country);
            return Ok(country);
        }

        // PUT api/countries
        [HttpPut]
        public async Task<ActionResult<Country>> Put(Country country)
        {
            if (country == null)
                return BadRequest();
            if (!(await service.Any(country.ID)))
                return NotFound();
            await service.Put(country);
            return Ok(country);
        }

        // DELETE api/users/delete/5
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<Country>> Delete(int id)
        {
            Country country = await service.Get(id);
            if (country == null)
                return NotFound();
            await service.Delete(country);
            return Ok(country);
        }
    }
}
