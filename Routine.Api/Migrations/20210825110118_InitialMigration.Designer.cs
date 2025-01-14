﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.Api.Data;

namespace Routine.Api.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    [Migration("20210825110118_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Introduction = "Google Company",
                            Name = "Google"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            Introduction = "Apple Company",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = new Guid("0f40e053-252b-4de7-ae6d-164e7fa87b85"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft2"
                        },
                        new
                        {
                            Id = new Guid("8f2bcc74-0226-4de3-8581-d179cf039407"),
                            Introduction = "Google Company",
                            Name = "Google2"
                        },
                        new
                        {
                            Id = new Guid("1f45d6c1-e5a0-435a-851c-418c818fa1e2"),
                            Introduction = "Apple Company",
                            Name = "Apple2"
                        },
                        new
                        {
                            Id = new Guid("92267a79-e640-4ecd-9ad2-26e58e68558d"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft3"
                        },
                        new
                        {
                            Id = new Guid("ab8f0e97-361f-4996-b449-2bfa8cd0c9df"),
                            Introduction = "Google Company",
                            Name = "Google3"
                        },
                        new
                        {
                            Id = new Guid("1d7317fa-e637-46c4-a132-557a2b0829fe"),
                            Introduction = "Apple Company",
                            Name = "Apple3"
                        },
                        new
                        {
                            Id = new Guid("5d654ea0-5434-4878-9346-c29d67882165"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft4"
                        },
                        new
                        {
                            Id = new Guid("04b37a9a-037f-4169-9a0f-ad25cb06dfe9"),
                            Introduction = "Google Company",
                            Name = "Google4"
                        },
                        new
                        {
                            Id = new Guid("6bd6bc9b-a502-4397-b161-e1963b28f6a1"),
                            Introduction = "Apple Company",
                            Name = "Apple4"
                        },
                        new
                        {
                            Id = new Guid("ee61d1ce-2882-4212-ab47-a99f34681c82"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft5"
                        },
                        new
                        {
                            Id = new Guid("50e92e5e-02b7-42bb-b9f4-5d89b42a05d1"),
                            Introduction = "Google Company",
                            Name = "Google5"
                        },
                        new
                        {
                            Id = new Guid("0a9975cf-befd-46d1-ab1b-e985b980d123"),
                            Introduction = "Apple Company",
                            Name = "Apple5"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b9e8ecd-71a5-46b5-8ec4-2a7a002d9ada"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("2e1c7b17-b912-43ed-896c-652735a00b6d"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("eb6401ae-9113-4d6c-9d2d-e9cc6208f1c6"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        },
                        new
                        {
                            Id = new Guid("7e2ebe97-11da-4b62-b644-f2885b7f038c"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("7061fd5a-b7ee-45a0-8a97-566f6dfc5c2e"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("94981ae0-0954-446c-87a8-58abbdbe8d6f"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        },
                        new
                        {
                            Id = new Guid("bbbf271a-e6f9-4584-a882-236e51114f6f"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("86d7915c-2575-438a-ac40-47ddaafa3708"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("4666e3ea-d14f-4996-a036-b3737bbda486"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.HasOne("Routine.Api.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
