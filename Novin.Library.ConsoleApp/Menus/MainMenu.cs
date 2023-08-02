using Novin.Library.ConsoleApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.Menus
{
    public static class MainMenu
    {
        public static Menu  Menu { get; set; }
        static MainMenu()
        {
            Menu = new Menu();
            Menu.Items.Add("1 - Books");
            Menu.Items.Add("2 - Members");
            Menu.Items.Add("3 - Borrows");
            Menu.Items.Add("0 - Exit");
        }
        public static void Show()
        {
            while(true)
            {
                Console.WriteLine("****** MAINMENU ******");
                var choice = Menu.Show();
                if(choice == 0)
                {
                    break;
                }
                else if(choice == 1) 
                {
                    BooksMenu.Show();
                }
                else if(choice == 2) 
                {
                    MembersMenu.Show();
                }
                else if(choice == 3)
                {
                    BorrowsMenu.Show();
                }
            }
        }
    }
}
