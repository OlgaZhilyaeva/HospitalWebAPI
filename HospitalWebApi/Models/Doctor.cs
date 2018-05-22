namespace HospitalWebApi.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DigitalSign { get; set; }

        public Department Department { get; set; }
        public HospitalUser User { get; set; }
    }
}
