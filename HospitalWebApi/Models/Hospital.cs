using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWebApi.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Documents { get; set; }
        public List<Department> Departments { get; set; }
    }
}
