using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;
using Novin.Library.ConsoleApp.Tools;
using Novin.Library.ConsoleApp.UI;
using Novin.Library.Core.Entites;
using Novin.Library.Infra.DB;
using Novin.Library.Infra.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Novin.Library.ConsoleApp.Menus
{
    public static class BorrowsMenu
    {
        public static Menu Menu { get; set; }
        static BorrowsMenu()
        {
            Menu=new Menu();
            Menu.Items.Add("1 - Add");
            Menu.Items.Add("2 - List");
            Menu.Items.Add("3 - Return");
            Menu.Items.Add("4 - Most Active Members");
            Menu.Items.Add("5 - Most Borrowed Books");
            Menu.Items.Add("0 - Exit");
        }
        public static void Show()
        {
            Console.Clear();
            while(true)
            {
                Console.WriteLine("****** BORROWSMENU ******");
                var choice = Menu.Show();
                var b=new Borrow();
                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    BorrowExtention.ChooseOne(b);
                }
                else if (choice == 2)
                {
                    BorrowExtention.ChooseTwo(b);
                }
                else if (choice == 3)
                {
                    BorrowExtention.ChooseThree(b); 
                }
                else if (choice == 4)
                {
                    BorrowExtention.ChooseFour(b);
                }
                else if (choice == 5)
                {
                    BorrowExtention.ChooseFive(b);
                }
            }
        }
    }
}
