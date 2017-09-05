using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProjectFluentAPI.Models
{
    public class Person
    {
        public Person()
        {
            Phones = new HashSet<Phone>();
            BirthDate = DateTime.Now;
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal HeightInFeet { get; set; }
        public byte[] Photo { get; set; }
        public bool IsActive { get; set; }
        public int NumberOfCars { get; set; }

        public virtual PersonType PersonType {get;set;}

        public virtual ICollection<Phone> Phones { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
