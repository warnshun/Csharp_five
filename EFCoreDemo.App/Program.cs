using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreDemo.Data;
using EFCoreDemo.Domain;

namespace EFCoreDemo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFCoreDemoContext();

            //var serieA = new League
            //{
            //    Country = "Italy",
            //    Name = "Serie A"
            //};

            //context.Leagues.Add(serieA);

            var serieA = context.Leagues.Single(l => l.Name == "Serie A");

            var serieB = new League
            {
                Country = "Italy",
                Name = "Serie B"
            };
            var serieC = new League
            {
                Country = "Italy",
                Name = "Serie C"
            };

            // 同種資料
            //context.Leagues.AddRange(serieB, serieC);
            //context.Leagues.AddRange(new List<League> {serieB, serieC});

            var milan = new Club
            {
                Name = "AC Milan",
                City = "Milan",
                DateOfEstablishment = new DateTime(1899, 12, 16),
                League = serieA
            };
            // 多種資料
            context.AddRange(serieB, serieC, milan);

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
