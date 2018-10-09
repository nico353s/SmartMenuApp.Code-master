using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace Bindings
{
    public class Binding
    {
        public void MenuID(string menupunkt)
        {
            // Menupunkt er den første del af menuspec.txt filen, så bliver den splittet ved ';' og MenuIDs er den anden liste
            if (menupunkt == "DoThis")
            {
                Console.WriteLine(Functions.DoThis());
            }
            else if (menupunkt == "DoThat")
            {
                Console.WriteLine(Functions.DoThat());
            }
            else if (menupunkt == "DoSomething")
            {
                Console.Write("Input: ");
                string somethingline = Console.ReadLine();
                Console.WriteLine(Functions.DoSomething(somethingline));
            }
            else if (menupunkt == "GetTheAnswerToLifeTheUniverseAndEverything")
            {
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }

            else if (menupunkt == "GaveTilAllan")
            {
                Console.WriteLine(Functions.GaveTilAllan());
            }
        }
    }
}
