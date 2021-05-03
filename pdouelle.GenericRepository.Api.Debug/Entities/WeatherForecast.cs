using System;
using System.Collections.Generic;
using pdouelle.Entity;

namespace pdouelle.GenericRepository.Api.Debug.Entities
{
    public class WeatherForecast : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Location> Locations { get; set; }
    }
}