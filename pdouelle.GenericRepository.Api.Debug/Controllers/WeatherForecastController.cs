using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pdouelle.GenericRepository.Api.Debug.Entities;

namespace pdouelle.GenericRepository.Api.Debug.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository<WeatherForecast> _repository;

        public WeatherForecastController(IRepository<WeatherForecast> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherForecastsAsync()
        {
            List<WeatherForecast> result = await _repository.Filter(include: source  => source.Include(x => x.Locations)).ToListAsync();

            return Ok(result);
        }
    }
}