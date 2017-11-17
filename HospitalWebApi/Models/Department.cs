using System.Collections.Generic;

namespace HospitalWebApi.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Ward> Wards { get; set; }
    }
}