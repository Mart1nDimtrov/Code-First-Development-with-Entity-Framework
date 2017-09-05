using Chapter2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
   public class Person
    {

        public Person ()
        {
            Phones = new HashSet<Phone>();
        }
        public int PersonId { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }

        [StringLength(1, MinimumLength = 1)]
        [Column(TypeName = "char")]
        public string MiddleName { get; set; }

        public DateTime? BirthDate { get; set; }
        public decimal HeightInFeet { get; set; }
        public byte[] Photo { get; set; }
        public bool IsActive { get; set; }
        public int NumberOfCars { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
