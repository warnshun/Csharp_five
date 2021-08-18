using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreDemo.Data;
using EFCoreDemo.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFCoreDemoContext();

            // League - Club - Player

            var serieA = context.Leagues.Single(l => l.Name == "Serie A");

            var juventus = new Club
            {
                League = serieA,
                Name = "Juventus",
                City = "Torino",
                DateOfEstablishment = new DateTime(1897, 11, 1),
                Players = new List<Player>
                {
                    new Player
                    {
                        Name = "C. Ronaldo",
                        DateOfBirth = new DateTime(1985, 2, 5)
                    }
                }
            };

            context.Clubs.Add(juventus);

            int count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
