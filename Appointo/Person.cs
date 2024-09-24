using System;
using System.Collections.Generic;

namespace Appointo
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }

        public List<Person> _patient = new();

        public Person() { }
        public Person(int id, string name, string surname, DateTime birthDate, string address, string phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
        }

        public virtual void Save(List<Person> persons)
        {
            int i = 0;

            foreach (Person person in persons)
            {
                _patient.Add(persons[i]);
                i++;
            }
        }
    }
}