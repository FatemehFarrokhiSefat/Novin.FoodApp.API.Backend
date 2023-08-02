using Novin.Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.Core.Entites
{
    public class Member : BaseEntity , IReadable
    {
        public String? Fullname { get; set; }
        public String? Address { get; set; }
        public int BooksBorrowed { get; set; }
        public void Read()
    {
        Console.WriteLine("Fullname :");
        Fullname = Console.ReadLine();
        Console.WriteLine("Address :");
        Address = Console.ReadLine();
    }
    public override string ToString()
    {
        return $"(Member) => {Id} {Fullname} {Address} {CreationTime}";
    }
    }
}
