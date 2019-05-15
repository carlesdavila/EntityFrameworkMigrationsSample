using System;
using EntityFrameworkMigrationsSample.Persistence;

namespace EntityFrameworkMigrationsSample.Client
{
    static class Program
    {
        private static readonly CustomerDbContext Context = new CustomerDbContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EntityFrameworkMigrationsSample!");

            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();

            Console.ReadKey();
        }
    }
}
