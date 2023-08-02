using Novin.Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.Core.Entites
{
    public class Book : BaseEntity , IReadable 
    {
        public String? Title { get; set; }
        public String? Writer { get; set; }
        public double price { get; set; }
        public int BooksBorrowed { get; set; }
        public void Read()
        {
            Console.WriteLine("Title:");
            Title=Console.ReadLine();
            Console.WriteLine("Writer:");
            Writer=Console.ReadLine();
            Console.WriteLine("price");
            price=double.Parse(Console.ReadLine()??"0");
        }
        public override string ToString()
        {
            return $"(Book) => {Id} {Title} {Writer} {price} {CreationTime} ";
        }
    }
}
