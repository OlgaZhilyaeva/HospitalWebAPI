namespace HospitalWebApi.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public Temperature Temperature { get; set; }
        public Patient Patient { get; set; }
    }
}