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

            // 需設有 DBSet
            var leagues = context.Leagues
                .FromSqlRaw("SELECT * FROM dbo.Leagues")
                .ToList();

            var leagues2 = context.Leagues
                .FromSqlInterpolated($"SELECT * FROM dbo.Clubs WHERE Id > {0}")
                .ToList();

            foreach (var league in leagues)
            {
                Console.WriteLine(league.Name);
            }

            // 無法執行查詢，返回影響行數
            var count = context.Database
                .ExecuteSqlRaw("EXEC dbo.RemoveGamePlayersProcedure {0}", 2);

            count = context.Database
                .ExecuteSqlInterpolated($"EXEC dbo.RemoveGamePlayersProcedure {2}");
        }
    }
}
