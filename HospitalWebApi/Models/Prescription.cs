using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWebApi.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string Name { get; set; }
        public Patient Patient { get; set; }
        public Medicine Medicine { get; set; }
        public string MedicineQuantity { get; set; }    
        public int Duration { get; set; }
    }
}
