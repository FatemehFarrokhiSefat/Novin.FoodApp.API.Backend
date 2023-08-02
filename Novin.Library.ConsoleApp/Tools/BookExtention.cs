using Microsoft.EntityFrameworkCore;
using Novin.Library.ConsoleApp.Menus;
using Novin.Library.Core.Entites;
using Novin.Library.Infra.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.Tools
{
    public static class BookExtention 
    {
        public static async void ChooseOne(this  Book A)
        {
            A.Read();

            using (var db = new NovinLibraryDB())
            {
                await db.Books.AddAsync(A);
                await db.SaveChangesAsync();
                Console.WriteLine("SuccessFull!");

            }
        }
        public static async void ChooseTwo(this Book B)
        {
            Console.WriteLine("Books List :");

            using (var db = new NovinLibraryDB())
            {
              (await db.Books.ToListAsync()).ForEach(b => Console.WriteLine(b));
            }
        }
        public static async void ChooseThree(this Book C)
        {
            Console.WriteLine("Book Id:");
            var id = int.Parse(Console.ReadLine() ?? "0");

            using (var db = new NovinLibraryDB())
            {
                var book = await db.Books.FirstOrDefaultAsync(b => b.Id == id);

                if (book == null)
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    Console.WriteLine(book);
                    book.Read();
                    await db.SaveChangesAsync();
                    Console.WriteLine("SuccessFull!");
                    Console.ReadKey();
                }
            }
        }
        public static async void ChooseFour(this Book D)
        {
            Console.WriteLine("Book Id:");
            var id = int.Parse(Console.ReadLine() ?? "0");

            using (var db = new NovinLibraryDB())
            {
                var book = await db.Books.FirstOrDefaultAsync(b => b.Id == id);

                if (book == null)
                {
                    Console.WriteLine("Not Found!");
                }
                else
                {
                    db.Books.Remove(book);
                    await db.SaveChangesAsync();
                    Console.WriteLine("SuccessFull!");
                }
            }
        }
    }
}
