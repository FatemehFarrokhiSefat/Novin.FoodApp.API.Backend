using Microsoft.EntityFrameworkCore;
using Novin.Library.ConsoleApp.Tools;
using Novin.Library.ConsoleApp.UI;
using Novin.Library.Core.Entites;
using Novin.Library.Infra.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.ConsoleApp.Menus
{
    public static class BooksMenu 
    {
        public static Menu Menu { get; set; }
    static BooksMenu()
    {
         Menu = new Menu();
            Menu.Items.Add("1 - Add");
            Menu.Items.Add("2 - List");
            Menu.Items.Add("3 - Update");
            Menu.Items.Add("4 - Remove");
            Menu.Items.Add("0 - Exit");
    }   
        public static async void Show()
        {
                Console.Clear();
            while(true)
            {
                Console.WriteLine("****** BOOKSMENU ******");
                var choice = Menu.Show();
                 var b = new Book();
                if(choice==0)
                {
                    break;
                }
                else if(choice==1)
                {
                    BookExtention.ChooseOne(b);
                }
                else if (choice==2)
                {
                    BookExtention.ChooseTwo(b);
                }
                else if( choice==3) 
                {
                    BookExtention.ChooseThree(b);
                }
                else if (choice==4)
                {
                   BookExtention.ChooseFour(b); 
                }    
            }
        }
    }
}
