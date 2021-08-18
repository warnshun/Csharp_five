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

            var italy = "Italy";



            var leagues = context.Leagues
                //.Where(l => l.Country == italy)
                // Country LIKE %e%
                // .Where(l => l.Country.Contains("e"))
                .Where(l => EF.Functions.Like(l.Country, "%e%"))
                .ToList();

            //var leagues2 = (
            //        from l in context.Leagues 
            //        where l.Country == "Italy"
            //        select l)
            //    .ToList();

            // ToList(), Find();  // ToListAsync();
            // First(), .FirstOrDefault(), Last(), LastOrDefault()
            // Single(), SingleOrDefault()
            // Count(), LongCount(), Min(), Max(), Average(), Sum()

            // 開啟資料庫連接
            //foreach (var league in context.Leagues)
            //{
            //    Console.WriteLine(league.Name);
            //}

            // 印出查詢的資料
            foreach (var league in leagues)
            {
                Console.WriteLine(league.Name);
            }


            var first = context.Leagues
                .SingleOrDefault(l => l.Id == 2);

            // Find() 先查詢記憶體
            var one = context.Leagues.Find(2);

            Console.WriteLine(first ?.Name);
            Console.WriteLine(one ?.Name);

            // Last() 需排序
            var last = context.Leagues
                .OrderBy(l => l.Id) // 正序
                //.OrderByDescending(l => l.Id) // 倒序
                .LastOrDefault(l => l.Name.Contains("e"));


            Console.WriteLine(last ?.Name);
        }
    }
}
