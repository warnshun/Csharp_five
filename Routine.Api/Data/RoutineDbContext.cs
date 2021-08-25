using System;
using Microsoft.EntityFrameworkCore;
using Routine.Api.Entities;

namespace Routine.Api.Data
{
    public class RoutineDbContext : DbContext
    {
        public RoutineDbContext(DbContextOptions<RoutineDbContext> options) : base(options)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Company>()
                .Property(c => c.Introduction).HasMaxLength(500);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeNo).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            // seed data
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    Name = "Microsoft",
                    Introduction = "Microsoft Company"
                },
                new Company
                {
                    Id = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    Name = "Google",
                    Introduction = "Google Company"
                },
                new Company
                {
                    Id = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    Name = "Apple",
                    Introduction = "Apple Company"
                },
                new Company
                {
                    Id = Guid.Parse("0f40e053-252b-4de7-ae6d-164e7fa87b85"),
                    Name = "Microsoft2",
                    Introduction = "Microsoft Company"
                },
                new Company
                {
                    Id = Guid.Parse("8f2bcc74-0226-4de3-8581-d179cf039407"),
                    Name = "Google2",
                    Introduction = "Google Company"
                },
                new Company
                {
                    Id = Guid.Parse("1f45d6c1-e5a0-435a-851c-418c818fa1e2"),
                    Name = "Apple2",
                    Introduction = "Apple Company"
                },
                new Company
                {
                    Id = Guid.Parse("92267a79-e640-4ecd-9ad2-26e58e68558d"),
                    Name = "Microsoft3",
                    Introduction = "Microsoft Company"
                },
                new Company
                {
                    Id = Guid.Parse("ab8f0e97-361f-4996-b449-2bfa8cd0c9df"),
                    Name = "Google3",
                    Introduction = "Google Company"
                },
                new Company
                {
                    Id = Guid.Parse("1d7317fa-e637-46c4-a132-557a2b0829fe"),
                    Name = "Apple3",
                    Introduction = "Apple Company"
                }, new Company
                {
                    Id = Guid.Parse("5d654ea0-5434-4878-9346-c29d67882165"),
                    Name = "Microsoft4",
                    Introduction = "Microsoft Company"
                },
                new Company
                {
                    Id = Guid.Parse("04b37a9a-037f-4169-9a0f-ad25cb06dfe9"),
                    Name = "Google4",
                    Introduction = "Google Company"
                },
                new Company
                {
                    Id = Guid.Parse("6bd6bc9b-a502-4397-b161-e1963b28f6a1"),
                    Name = "Apple4",
                    Introduction = "Apple Company"
                }, new Company
                {
                    Id = Guid.Parse("ee61d1ce-2882-4212-ab47-a99f34681c82"),
                    Name = "Microsoft5",
                    Introduction = "Microsoft Company"
                },
                new Company
                {
                    Id = Guid.Parse("50e92e5e-02b7-42bb-b9f4-5d89b42a05d1"),
                    Name = "Google5",
                    Introduction = "Google Company"
                },
                new Company
                {
                    Id = Guid.Parse("0a9975cf-befd-46d1-ab1b-e985b980d123"),
                    Name = "Apple5",
                    Introduction = "Apple Company"
                }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.Parse("5b9e8ecd-71a5-46b5-8ec4-2a7a002d9ada"),
                    CompanyId = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    DateOfBirth = new DateTime(1976, 1, 2),
                    EmployeeNo = "MS231",
                    FirstName = "Nick",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("2e1c7b17-b912-43ed-896c-652735a00b6d"),
                    CompanyId = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "MS245",
                    FirstName = "Vince",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("EB6401AE-9113-4D6C-9D2D-E9CC6208F1C6"),
                    CompanyId = Guid.Parse("bbdee09c-089b-4d30-bece-44df5923716c"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "MS279",
                    FirstName = "Maria",
                    LastName = "Los",
                    Gender = Gender.Female
                },
                new Employee
                {
                    Id = Guid.Parse("7E2EBE97-11DA-4B62-B644-F2885B7F038C"),
                    CompanyId = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    DateOfBirth = new DateTime(1976, 1, 2),
                    EmployeeNo = "GG231",
                    FirstName = "Nick",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("7061FD5A-B7EE-45A0-8A97-566F6DFC5C2E"),
                    CompanyId = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "GG245",
                    FirstName = "Vince",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("94981AE0-0954-446C-87A8-58ABBDBE8D6F"),
                    CompanyId = Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "GG279",
                    FirstName = "Maria",
                    LastName = "Los",
                    Gender = Gender.Female
                },
                new Employee
                {
                    Id = Guid.Parse("BBBF271A-E6F9-4584-A882-236E51114F6F"),
                    CompanyId = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    DateOfBirth = new DateTime(1976, 1, 2),
                    EmployeeNo = "AP231",
                    FirstName = "Nick",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("86D7915C-2575-438A-AC40-47DDAAFA3708"),
                    CompanyId = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "AP245",
                    FirstName = "Vince",
                    LastName = "Carter",
                    Gender = Gender.Male
                },
                new Employee
                {
                    Id = Guid.Parse("4666E3EA-D14F-4996-A036-B3737BBDA486"),
                    CompanyId = Guid.Parse("5efc910b-2f45-43df-afae-620d40542853"),
                    DateOfBirth = new DateTime(1981, 12, 5),
                    EmployeeNo = "AP279",
                    FirstName = "Maria",
                    LastName = "Los",
                    Gender = Gender.Female
                }
                );
        }
    }
}
