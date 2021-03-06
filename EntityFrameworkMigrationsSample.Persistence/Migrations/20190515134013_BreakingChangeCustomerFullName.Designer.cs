﻿// <auto-generated />
using EntityFrameworkMigrationsSample.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkMigrationsSample.Persistence.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20190515134013_BreakingChangeCustomerFullName")]
    partial class BreakingChangeCustomerFullName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkMigrationsSample.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "UserFirstName1 UserLastName1"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "UserFirstName2 UserLastName2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
