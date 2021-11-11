using System;
using System.Collections.Generic;
using BusinessLogic;
using BusinessLogic.Models;
using DAL;

namespace UI
{
    class Program
    {
        private static PatientServise _patientServise;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            _patientServise = new PatientServise(new PatientRepository());

            Console.WriteLine("Input Method:\n" +
                "Find by Name                              (1)\n" +
                "Search for the age below the entered one  (2)\n" +
                "Find Critical Statuses                    (3)\n" +
                "Find by Surename                          (4)");

            var key = Console.ReadKey();

            try
            {
                ValidateInput(key);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of the range of values.");
                throw;
            }

            int method = int.Parse(key.KeyChar.ToString());

            if (method == 1)
                FindByName();

            else if (method == 2)
                FindLessThen();

            else if (method == 3)
                FindByCritical();

            else
                FindBySurname();
        }

        static void FindByName()
        {
            Console.WriteLine("Enter a name.");
            string name = Console.ReadLine().Trim();

            try
            {
                ConsoleWriteFindPatients(_patientServise.FindByName(name), name);
            }
            catch(Exception)
            {
                Console.WriteLine("Did not enter a value.");
                throw;
            }

        }

        static void FindBySurname()
        {
            Console.WriteLine("Enter a surname.");
            string surname = Console.ReadLine().Trim();

            try
            {
                ConsoleWriteFindPatients(_patientServise.FindBySurname(surname), surname);
            }
            catch (Exception)
            {
                Console.WriteLine("Did not enter a value.");
                throw;
            }

        }

        static void FindLessThen()
        {
            Console.WriteLine("Enter the age.");
            int age = int.Parse(Console.ReadLine().Trim());

            try
            {
                ConsoleWriteFindPatients(_patientServise.LessThan(age), age.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Out of the range of values.");
                throw;
            }

        }

        static void FindByCritical()
        {
            ConsoleWriteFindPatients(_patientServise.Critical(), "Critical patients");
        }

        static void ConsoleWriteFindPatients(IEnumerable<Patient> patients, string description)
        {
            Console.WriteLine($"\n{description}\n");

            if (patients != null)
            {
                foreach (var patient in patients)
                    Console.WriteLine($"{patient.Name} {patient.Surname}");
            }

            else
                Console.WriteLine("No patients were found.");

            Console.WriteLine("\nThe search is completed.\nGoodbye.");
        }

        static void ValidateInput(ConsoleKeyInfo keyInfo)
        {
            char keyAsChar = keyInfo.KeyChar;
            int keyAsInt = int.Parse(keyAsChar.ToString());

            if (keyAsInt >= 5 || keyAsInt <= 0)
            {
                throw new ArgumentOutOfRangeException("Out of the range of values.");
            }
        }
    }
}
