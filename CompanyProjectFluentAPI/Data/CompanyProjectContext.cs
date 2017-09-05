namespace CompanyProjectFluentAPI.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanyProjectContext : DbContext
    {
        public CompanyProjectContext()
            : base("name=CompanyProjectContext")
        {
            Database.SetInitializer(
            new DropCreateDatabaseAlways<CompanyProjectContext>());
            
        }

        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<PersonType> PersonTypes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonTypeConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
          
        }


        }

}