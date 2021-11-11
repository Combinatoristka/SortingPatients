using System;
namespace BusinessLogic.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public EStatus Status { get; set; }
    }
}
