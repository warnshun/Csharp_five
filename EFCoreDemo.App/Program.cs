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

            // Update
            // 需要被追蹤才能被修改
            //var league = context.Leagues.First();
            // 多筆修改
            var leagues = context.Leagues.Skip(1).Take(3).ToList();

            // Modify
            //league.Name += "!!";
            foreach (var l in leagues)
            {
                l.Name += "!!";
            }

            var count = context.SaveChanges();

            Console.WriteLine(count);

            // 模仿前端 Json 資料
            var leagueJson = context.Leagues.AsNoTracking().First();
            leagueJson.Name += "++";

            // 加入追蹤 並 Modify
            context.Leagues.Update(leagueJson);
            // UpdateRange

            var countJson = context.SaveChanges();

            Console.WriteLine(countJson);
        }
    }
}
