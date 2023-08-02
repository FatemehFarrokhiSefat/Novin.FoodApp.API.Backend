using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.UI
{
    public class Menu
    {
        public List<string> Items { get; set; } = new List<string>();
        public int Show()
        {
            Items.ForEach(m => Console.WriteLine (m) );
            Console.Write("Your Choice :");
            var choice = int.Parse(Console.ReadLine()??"0");
            return choice;
        }
    }
}
