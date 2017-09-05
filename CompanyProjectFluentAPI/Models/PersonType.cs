using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProjectFluentAPI.Models
{
    public class PersonType
    {
        public int PersonTypeId { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
