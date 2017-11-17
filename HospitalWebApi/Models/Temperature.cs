using System;

namespace HospitalWebApi.Models
{
    public class Temperature
    {
        public int TemperatureId { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}