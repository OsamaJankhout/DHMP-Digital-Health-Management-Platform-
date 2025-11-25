namespace DHMPFinal.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        // Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<DoctorPatient> DoctorPatients { get; set; }
    }

}
