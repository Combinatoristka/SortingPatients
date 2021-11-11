using System;
using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetByName(string name);

        IEnumerable<Patient> GetBySurname(string surname);

        IEnumerable<Patient> GetByAge(int age);

        IEnumerable<Patient> GetByStatus(EStatus status);
    }
}
