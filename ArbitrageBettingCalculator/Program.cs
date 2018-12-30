using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArbitrageBettingCalculator
{
    
    static void Main(string[] args)
    {

        //Initial variable declarations
        

        int payout1, payout2, betAmount1, betAmount2, grossprofit1, grossprofit2, netprofit1, netprofit2;
        string payout1str, payout2str, betAmount1str, betAmount2str, restart;

        //Getting the inputs from the user

        Console.WriteLine("Please enter the payout factor if Team A wins");
        payout1str = Console.ReadLine();
        payout1 = int.Parse(payout1str);

        Console.WriteLine("Please enter the payout factor if Team B wins");
        payout2str = Console.ReadLine();
        payout2 = int.Parse(payout2str);

        Console.WriteLine("Please enter the amount that you wish to bet on Team A winning (in pennies)");
        betAmount1str = Console.ReadLine();
        betAmount1 = int.Parse(betAmount1str);

        Console.WriteLine("Please enter the amount that you wish to bet on Team B winning (in pennies)");
        betAmount2str = Console.ReadLine();
        betAmount2 = int.Parse(betAmount2str);

        //Calc standalone method...

        //...up to here

        //Calculation and output

        grossprofit1 = (payout1) * betAmount1;
        grossprofit2 = (payout2) * betAmount2;

        netprofit1 = grossprofit1 - betAmount2;
        netprofit2 = grossprofit2 - betAmount1;

        if (netprofit1 > 0 & netprofit2 > 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Profit is guarranteed!");
        }
        else if (netprofit1 < 0 & netprofit2 < 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Loss is certain...");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Profit is not guarranteed...");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Profit if Team A wins:" + netprofit1);
        Console.WriteLine("Profit if Team B wins:" + netprofit2);
        Console.WriteLine("\n");
        Console.WriteLine("Enter r to restart");

        restart = Console.ReadLine();
        if (restart == "r")
        {
            Main(null);
        }
    }
}
