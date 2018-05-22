namespace HospitalWebApi.Models
{
    public class Nurse
    {
        public int NurseId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DigitalSign { get; set; }

        public HospitalUser User { get; set; }
        public Department Department { get; set; }
    }
}
