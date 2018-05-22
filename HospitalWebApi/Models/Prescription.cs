using System;

namespace HospitalWebApi.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string Name { get; set; }
        public string MedicineQuantity { get; set; }    
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public Patient Patient { get; set; }
        public Medicine Medicine { get; set; }
        public Doctor Doctor { get; set; }
    }
}
