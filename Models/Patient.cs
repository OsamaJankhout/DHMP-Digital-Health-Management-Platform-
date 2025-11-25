namespace DHMPFinal.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string MedicalRecords { get; set; }

        // Foreign Key to Pharmacy
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }

        // Navigation Properties
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<DoctorPatient> DoctorPatients { get; set; }
    }

}
