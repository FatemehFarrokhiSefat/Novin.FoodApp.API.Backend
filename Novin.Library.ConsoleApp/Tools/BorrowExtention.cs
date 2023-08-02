using Microsoft.EntityFrameworkCore;
using Novin.Library.Core.Entites;
using Novin.Library.Infra.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.Tools
{
    public static class BorrowExtention
    {
       public static async void ChooseOne(this Borrow A)
       {
            using (var db = new NovinLibraryDB())
            {
                try
                {
                    Console.WriteLine("Borrow Time :");
                    A.BorrowTime = DateTime.Parse(Console.ReadLine() ?? "0");

                    db.Books.ToList().ForEach(x => Console.WriteLine(x));
                    Console.WriteLine("Book Id :");
                    A.BookId = int.Parse(Console.ReadLine() ?? "0");

                    db.Members.ToList().ForEach(x => Console.WriteLine(x));
                    Console.WriteLine("Member Id :");
                    A.MemberId = int.Parse(Console.ReadLine() ?? "0");

                    var borrow =
                        db.Borrows
                          .ToList()
                          .FirstOrDefault(x => x.BookId == A.BookId && x.ReturnTime == null);

                    if (borrow != null)
                    {
                        Console.WriteLine("This Book Is Already Borrowed And Has Not Been Returned Yet!");
                    }
                    else
                    {
                        await db.Borrows.AddAsync(A);
                        await db.SaveChangesAsync();
                        Console.WriteLine("SuccessFull!");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("BookId"))
                    {
                        Console.WriteLine("Books Not Found!");
                    }
                    else if (ex.InnerException.Message.Contains("MemberId"))
                    {
                        Console.WriteLine("Member Not Found!");
                    }
                }
            }
       }
        public static void ChooseTwo(this Borrow B)
        {
            Console.WriteLine("Borrows List :");

            using (var db = new NovinLibraryDB())
            {
                db.Borrows
                   .Include(m => m.Book)
                   .Include(m => m.Member)
                   .Where(m => m.ReturnTime == null)
                   .ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        public static async void ChooseThree(this Borrow C)
        {
            using (var db = new NovinLibraryDB())
            {
                Console.WriteLine("Borrow List:");
                var id = int.Parse(Console.ReadLine() ?? "0");
                var borrow = await db.Borrows.FirstOrDefaultAsync(x => x.Id == id);

                if (borrow == null)
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    borrow.ReturnTime = DateTime.Now;
                    await db.SaveChangesAsync();
                    Console.WriteLine("SuccessFull!");
                }
            }
        }
        public static async void ChooseFour(this Borrow D)
        {
            Console.WriteLine("Active Member List:");

            using (var db = new NovinLibraryDB())
            {
                var person = await db.Members
                    .OrderByDescending(m => m.BooksBorrowed)
                    .FirstOrDefaultAsync();

                if (person != null)
                {
                    Console.WriteLine($"Most Active Member: " +
                        $"Id:{person.Id} / " +
                        $"Fullname:{person.Fullname} / " +
                        $"Address:{person.Address} ");
                }
                else
                {
                    Console.WriteLine("No Active Member Found");
                }
            }
        }
        public static async void ChooseFive(this Borrow E)
        {
            Console.WriteLine("Active Book List:");

            using (var db = new NovinLibraryDB())
            {
                var Borrowed = await db.Books
                    .OrderByDescending(c => c.BooksBorrowed)
                    .FirstOrDefaultAsync();

                if (Borrowed != null)
                {
                    Console.WriteLine($" Most Borrowed Books:  " +
                        $"Id:{Borrowed.Id} / " +
                        $"Title:{Borrowed.Title} / " +
                        $"Writer:{Borrowed.Writer} / " +
                        $"price:{Borrowed.price}");
                }
                else
                {
                    Console.WriteLine("No Active Book Found");
                }
            }
        }
    }
}
