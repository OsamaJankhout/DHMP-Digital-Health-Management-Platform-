namespace DHMPFinal.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }

}
