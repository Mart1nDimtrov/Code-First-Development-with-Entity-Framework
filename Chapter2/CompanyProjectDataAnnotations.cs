using Chapter2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class CompanyProjectDataAnnotations
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyProjectContextData())
            {
                context.Database.CreateIfNotExists();
                var person = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    IsActive = true
                };
                person.Phones.Add(new Phone { PhoneNumber = "123-446-7890" });
                person.Phones.Add(new Phone { PhoneNumber = "123-446-7891" });
                context.People.Add(person);
                context.SaveChanges();
            }

            using (var context = new CompanyProjectContextData())
            {
                var savedPeople = context.People;
                foreach(var person in savedPeople)
                {
                    Console.WriteLine("Last name:{0},first name:{1},id {2}",
                            person.LastName, person.FirstName, person.PersonId);
                }

            }

            using (var context = new CompanyProjectContextData())
            {
                var savedPeople = context.People;
                if (savedPeople.Any())
                {
                    var person = savedPeople.First();
                    person.FirstName = "Johnyy";
                    person.LastName = "Benson";
                    context.SaveChanges();
                }
            }

            using (var context = new CompanyProjectContextData())
            {
                var personId = 2;
                var person = context.People.Find(personId);
                if (person != null)
                {
                    context.People.Remove(person);
                    context.SaveChanges();
                }
            }


                Console.ReadKey();


            }
    }
}
