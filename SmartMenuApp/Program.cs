using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Console.WriteLine("Tryk 1 for Dansk");
            Console.WriteLine("Press 2 for English");
            string input = Console.ReadLine();
            int.TryParse(input, out int parsedinput);
            if (parsedinput != 1 && parsedinput != 2) 
            {
                Console.WriteLine("Fejlagtigt Input");
            }
            else
            {
                menu.LoadMenu(menu.Sprog(parsedinput));
                menu.Activate();
            }
            
            

        }
    }
}
