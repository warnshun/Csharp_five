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

            // Delete
            // 只能刪除被追蹤的資料
            var milan = context.Clubs.Single(c => c.Name == "AC Milan");

            // 調用刪除方法
            context.Clubs.Remove(milan);
            //context.Clubs.RemoveRange(milan, milan);

            //context.Remove(milan);
            //context.RemoveRange(milan, milan);

            var count = context.SaveChanges();

            Console.WriteLine(count);
        }
    }
}
