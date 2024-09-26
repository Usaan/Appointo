namespace Appointo
{
    class Doctor : Person
    {
        public string Specialization { get; set; }
        public string HelthPlan { get; set; }

        public Doctor(int idDoctor) :base()
        {
            Id = idDoctor;
        }

        public Doctor(string specialization, string helthPlan, int id, string name, string surname, DateTime birthDate, string address, string phone) : base(id, name, surname, birthDate, address, phone)
        {
            Specialization = specialization;
            HelthPlan = helthPlan;
        }

        public override void Save(List<Person> persons)
        {
            base.Save(persons);
        }
    }
}