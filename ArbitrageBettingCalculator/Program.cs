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
        
        int payoutWin, payoutLoss, betAmountWin, betAmountLoss, grossProfitWin, grossProfitLoss, netProfitWin, netProfitLoss;
        string payoutWinString, payoutLossString, betAmountWinString, betAmountLossString, restart;

        //Getting the inputs from the user

        Console.WriteLine("Please enter the payout factor if your team wins");
        payoutWinString = Console.ReadLine();
        payoutWin = int.Parse(payoutWinString);

        Console.WriteLine("Please enter the payout factor if your team loses");
        payoutLossString = Console.ReadLine();
        payoutLoss = int.Parse(payoutLossString);



        Console.WriteLine("Please enter the amount that you wish to bet on your team winning (in pennies)");
        betAmountWinString = Console.ReadLine();
        betAmountWin = int.Parse(betAmountWinString);

        Console.WriteLine("Please enter the amount that you wish to bet on your team losing (in pennies)");
        betAmountLossString = Console.ReadLine();
        betAmountLoss = int.Parse(betAmountLossString);

        //Calc standalone method...

        //...up to here

        //Calculation and output

        grossProfitWin = (payoutWin) * betAmountWin;
        grossProfitLoss = (payoutLoss) * betAmountLoss;

        netProfitWin = grossProfitWin - betAmountLoss;
        netProfitLoss = grossProfitLoss - betAmountWin;

        if (netProfitWin > 0 & netProfitLoss > 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Profit is guarranteed!");
        }
        else if (netProfitWin < 0 & netProfitLoss < 0)
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
        Console.WriteLine("Profit if your team wins:" + netProfitWin);
        Console.WriteLine("Profit if your team loses:" + netProfitLoss);
        Console.WriteLine("\n");
        Console.WriteLine("Enter r to restart");

        restart = Console.ReadLine();
        if (restart == "r")
        {
            Main(null);
        }
    }
}
