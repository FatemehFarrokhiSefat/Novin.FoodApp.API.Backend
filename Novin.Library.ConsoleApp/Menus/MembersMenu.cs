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
    public static class MembersMenu
    {
        public static Menu Menu { get; set; }
        static MembersMenu()
        {
            Menu = new Menu();
            Menu.Items.Add("1 - Add");
            Menu.Items.Add("2 - List");
            Menu.Items.Add("3 - Update");
            Menu.Items.Add("4 - Remove");
            Menu.Items.Add("0 - Exit");
        }
        public static void Show()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("****** MEMBERMENU ******");
                var choice=Menu.Show();
                var m = new Member();
                if (choice==0)
                {
                    break;
                }
                else if (choice==1)
                {
                    MemberExtention.ChooseOne(m);
                }
                else if(choice==2) 
                {
                    MemberExtention.ChooseTwo(m);
                }
                else if(choice==3)
                {
                   MemberExtention.ChooseThree(m); 
                }
                else if(choice==4)
                {
                   MemberExtention.ChooseFour(m);
                }
            }
        }
    }
}
