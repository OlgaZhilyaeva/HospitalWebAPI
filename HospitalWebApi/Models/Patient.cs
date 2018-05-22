using System.Collections.Generic;

namespace HospitalWebApi.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Documents { get; set; }

        public Sensor Sensor { get; set; }
        public HospitalUser User { get; set; }
        public Ward Ward { get; set; }
    }
}