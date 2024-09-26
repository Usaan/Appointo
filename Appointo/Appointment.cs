using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo
{
    public enum AppointmentStatus
    {
        Scheduled,
        Canceled,
        Completed
    }
    class Appointment
    {
        public int AppointmentId { get; private set; }
        public Patient PatientData { get; private set; }
        public Doctor DoctorData { get; private set; }
        public DateTime AppointmentDate { get; private set; }
        public string Reason { get; private set; }
        public AppointmentStatus Status { get; private set; }

        public Appointment(int appointmentId, Patient patientData, Doctor doctorData, DateTime appointmentDate, string reason)
        {
            AppointmentId = appointmentId;
            PatientData = patientData;
            DoctorData = doctorData;
            AppointmentDate = appointmentDate;
            Reason = reason;
            Status = AppointmentStatus.Scheduled;
        }
        public void ChangeStatus(AppointmentStatus newStatus)
        {
            Status = newStatus;
        }
    }
}
