using System;
using System.Collections.Generic;
using BusinessLogic.Models;
using BusinessLogic.Repositories;

namespace BusinessLogic
{
    public class PatientServise
    {
        private readonly IPatientRepository _patientRepository;

        public PatientServise(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }


        public IEnumerable<Patient> FindByName(string name)
        {
            if (name == null)
                throw new ArgumentNullException("The variable has a null value.");
            return _patientRepository.GetByName(name);
        }

        public IEnumerable<Patient> FindBySurname(string surname)
        {
            if (surname == null)
                throw new ArgumentNullException("The variable has a null value.");
            return _patientRepository.GetBySurname(surname);
        }

        public IEnumerable<Patient> LessThan(int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException("Out of the range of values.");

            var patients = new List<Patient>();
            for (int i = age - 1; i >= 0; i--)
            {
                patients.AddRange(_patientRepository.GetByAge(i));
            }
            return patients;
        }

        public IEnumerable<Patient> Critical()
        {
            return _patientRepository.GetByStatus(EStatus.Critical);
        }
    }
}
