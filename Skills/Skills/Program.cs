using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Skills
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                db.SaveChanges();
            }
            Console.WriteLine("Hello World!");
        }
    }

    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public List<Option> Options { get; set; }
    }

    public class Option
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid? ParentId { get; set; }
        public Option Parent { get; set; }
    }

    public class Context: DbContext
    {
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Option> Options { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Skills;Trusted_Connection=True;");
        }
    }
}
