namespace DHMPFinal.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medication { get; set; }
        public DateTime DateIssued { get; set; }

        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        
        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }

}
