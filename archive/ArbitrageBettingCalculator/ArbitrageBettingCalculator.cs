using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArbitrageBettingCalculator
{
    static void Main(string[] args)
    {
        float payout1, payout2, betAmount1, betAmount2, grossprofit1, grossprofit2, netprofit1, netprofit2;
        string payout1str, payout2str, betAmount1str, betAmount2str, restart;

        Console.WriteLine("Please enter the payout if Team A wins");
        payout1str = Console.ReadLine();
        payout1 = float.Parse(payout1str);

        Console.WriteLine("Please enter the payout if Team B wins");
        payout2str = Console.ReadLine();
        payout2 = float.Parse(payout2str);

        Console.WriteLine("Please enter the amount that you wish to bet on Team A winning");
        betAmount1str = Console.ReadLine();
        betAmount1 = float.Parse(betAmount1str);

        Console.WriteLine("Please enter the amount that you wish to bet on Team B winning");
        betAmount2str = Console.ReadLine();
        betAmount2 = float.Parse(betAmount2str);

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
