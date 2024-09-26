namespace Appointo
{
    class Patient : Person
    {
        public Doctor DoctorData { get; set; }

        private List<Appointment> _appointments = new();

        public Patient(int idPatient)
        {
            Id = idPatient;
        }

        public Patient(Doctor doctorData, int id, string name, string surname, DateTime birthDate, string address, string phone) : base(id, name, surname, birthDate, address, phone)
        {
            DoctorData = doctorData;
        }

        public override void Save(List<Person> persons)
        {
            base.Save(persons);
        }

        public void Remove(List<Person> persons, int selectedId)
        {
            persons.Remove(persons.Find(patient => patient.Id == selectedId));
        }

        public void ScheduleAppointment(int appointmentId, Doctor doctor, DateTime date, string reason)
        {
            Appointment newAppointment = new Appointment(appointmentId, this, doctor, date, reason);
            _appointments.Add(newAppointment);
        }

        public void CancelAppointment(int appointmentId)
        {
            Appointment appointment = _appointments.Find(a => a.AppointmentId == appointmentId);
            if (appointment != null)
            {
                appointment.ChangeStatus(AppointmentStatus.Canceled);
            }
        }

        public List<Appointment> GetAppointments()
        {
            return _appointments;
        }

        public void CompleteAppointment(int appointmentId)
        {
            Appointment appointment = _appointments.Find(a => a.AppointmentId == appointmentId);
            if (appointment != null)
            {
                appointment.ChangeStatus(AppointmentStatus.Completed); 
            }
        }
    }
}