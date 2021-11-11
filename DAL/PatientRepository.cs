using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Models;
using BusinessLogic.Repositories;

namespace DAL
{
    public class PatientRepository : IPatientRepository
    {
        public static IEnumerable<Patient> GetPatients()
        {
            yield return new Patient
            {
                Name = "Alex",
                Surname = "Mitchel",
                Age = 21,
                Status = EStatus.Critical
            };

            yield return new Patient
            {
                Name = "Kate",
                Surname = "Pupsvel",
                Age = 18,
                Status = EStatus.Critical
            };
            yield return new Patient
            {
                Name = "Georgy",
                Surname = "Robbinson",
                Age = 42,
                Status = EStatus.Normal
            };

            yield return new Patient
            {
                Name = "LG",
                Surname = "Company",
                Age = 120,
                Status = EStatus.Normal
            };
            yield return new Patient
            {
                Name = "Mikky",
                Surname = "Mouse",
                Age = 30,
                Status = EStatus.Critical
            };

            yield return new Patient
            {
                Name = "Ann",
                Surname = "Jastin",
                Age = 25,
                Status = EStatus.Normal
            };
            yield return new Patient
            {
                Name = "Bob",
                Surname = "Marline",
                Age = 19,
                Status = EStatus.Critical
            };

            yield return new Patient
            {
                Name = "Bob",
                Surname = "Jastin",
                Age = 22,
                Status = EStatus.Critical
            };
            yield return new Patient
            {
                Name = "Alin",
                Surname = "Grafkina",
                Age = 38,
                Status = EStatus.Normal
            };
            yield return new Patient
            {
                Name = "Sam",
                Surname = "Lukas",
                Age = 57,
                Status = EStatus.Normal
            };
            yield return new Patient
            {
                Name = "Din",
                Surname = "Graf",
                Age = 99,
                Status = EStatus.Normal
            };
        }


        public IEnumerable<Patient> GetByName(string name)
        {
            return GetPatients().Where(patient => patient.Name == name);
        }

        public IEnumerable<Patient> GetBySurname(string surname)
        {
            return GetPatients().Where(patient => patient.Surname == surname);
        }

        public IEnumerable<Patient> GetByAge(int age)
        {
            return GetPatients().Where(patient => patient.Age == age);
        }

        public IEnumerable<Patient> GetByStatus(EStatus status)
        {
            return GetPatients().Where(patient => patient.Status == status);
        }
    }
}
