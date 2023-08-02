using Novin.Library.Core.Entites;
using Novin.Library.Infra.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.Tools
{
    public static class MemberExtention
    {
        public static void ChooseOne(this Member A)
        {
            A.Read();

            using (var db = new NovinLibraryDB())
            {
                db.Members.Add(A);
                db.SaveChanges();
                Console.WriteLine("SuccessFull!");
            }
        }
        public static void ChooseTwo(this Member B)
        {
            Console.WriteLine("Member Id:");

            using (var db = new NovinLibraryDB())
            {
                db.Members.ToList().ForEach(m => Console.WriteLine(m));
            }
        }
        public static void ChooseThree(this Member C)
        {
            Console.WriteLine("Member Id:");
            var id = int.Parse(Console.ReadLine() ?? "0");

            using (var db = new NovinLibraryDB())
            {
                var member = db.Members.FirstOrDefault(m => m.Id == id);

                if (member == null)
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(member);
                    member.Read();
                    db.SaveChanges();
                    Console.WriteLine("SuccessFull");
                }
            }
        }
        public static void ChooseFour(this Member D)
        {
            Console.WriteLine("Member Id");
            var id = int.Parse(Console.ReadLine() ?? "0");

            using (var db = new NovinLibraryDB())
            {
                var member = db.Members.FirstOrDefault(db => db.Id == id);

                if (member == null)
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    db.Members.Remove(member);
                    db.SaveChanges();
                    Console.WriteLine("SuccessFull");
                }
            }
        }
    }
}
