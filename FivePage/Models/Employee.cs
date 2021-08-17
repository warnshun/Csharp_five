using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FivePage.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public bool IsFired { get; set; }
    }

    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}
