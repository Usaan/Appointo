namespace Appointo
{
    class Patient : Person
    {
        public Doctor DoctorData { get; set; }
        // Aqui vai um instanciamento da lista de consultas (fazer como private)

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

        // aqui vai um método público p agentar as consultas pegando a lista de consultas e percorrendo ela na 
        // mesma lógica que o método save de Person
    }
}