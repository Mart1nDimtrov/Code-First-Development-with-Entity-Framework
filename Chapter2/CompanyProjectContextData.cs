namespace Chapter2
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanyProjectContextData : DbContext
    {

        public CompanyProjectContextData()
            : base("name=Context")
        {
            Database.SetInitializer(new DropCreateCompanyProjectWithSeedData());
        }

            public virtual DbSet<Person> People { get; set; }
            public virtual DbSet<Company> Companies { get; set; }
            public virtual DbSet<Phone> Phones { get; set; }
    }
    public class DropCreateCompanyProjectWithSeedData : DropCreateDatabaseAlways<CompanyProjectContextData>
    {
        protected override void Seed(CompanyProjectContextData context)
        {
            context.Companies.Add(new Company
            {
                CompanyName = "My company"
            });
    }
    }
}
