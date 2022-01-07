using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCode1st.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options) : base(options)
        {

        }
        public DbSet<People> People { get; set; }
        public DbSet<House> House { get; set; }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<House> House { get; set; }
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
