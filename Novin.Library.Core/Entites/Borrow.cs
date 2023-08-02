using Novin.Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.Core.Entites
{
    public class Borrow : BaseEntity , IReadable 
    {
        public DateTime BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Member Member { get; set; }
        public int  MemberId { get; set; }
        public void Read()
        {
        }
        public override string ToString()
        {
            return $"(Borrow) {Id} Book=({Book.Title} {Book.Writer}) Member=({Member.Fullname} {Member.Address}) {BorrowTime}";
        }
    }
}
