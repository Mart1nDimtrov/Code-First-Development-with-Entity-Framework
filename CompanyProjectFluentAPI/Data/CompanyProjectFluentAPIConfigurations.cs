using CompanyProjectFluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProjectFluentAPI.Data
{
    public class PersonConfiguration :
         EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasMany(p => p.Phones)
                .WithRequired();
            Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();
            Property(p => p.LastName).HasMaxLength(30);
            Property(p => p.MiddleName)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsUnicode(false);
            Property(p => p.HeightInFeet)
                .HasPrecision(4, 2);
            Property(p => p.Photo)
                .IsVariableLength()
                .HasMaxLength(4000);
            Property(p => p.BirthDate)
                .IsOptional();
          
            HasMany(p => p.Companies).WithMany(c => c.Persons)
                .Map(m =>
                {
                    m.MapLeftKey("PersonId");
                    m.MapRightKey("CompanyId");
                });
        }
    }

    public class PersonTypeConfiguration :
EntityTypeConfiguration<PersonType>
    {
        public PersonTypeConfiguration()
        {
            HasMany(pt => pt.Persons)
                .WithOptional(p => p.PersonType)
                .WillCascadeOnDelete(false);
        }
    }

    public class CompanyConfiguration :
      EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {

        }
    }

    public class PhoneConfiguration :
  EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {

        }
    }


}
