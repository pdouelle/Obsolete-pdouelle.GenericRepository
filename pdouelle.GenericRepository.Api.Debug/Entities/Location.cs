using System;
using System.ComponentModel.DataAnnotations;
using pdouelle.Entity;

namespace pdouelle.GenericRepository.Api.Debug.Entities
{
    public class Location: IEntity
    {
        [Key] public Guid Id { get; set; }
        public string Description { get; set; }
        
        public Guid? WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}