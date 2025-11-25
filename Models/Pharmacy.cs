namespace DHMPFinal.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Medicine { get; set; }

        // Navigation Properties
        public ICollection<Patient> Patients { get; set; }
    }
}
