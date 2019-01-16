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
        
        int payoutWin, payoutLoss, payoutDraw, betAmountWin, betAmountLoss, betAmountDraw, grossProfitWin, grossProfitLoss, grossProfitDraw, netProfitWin, netProfitLoss, netProfitDraw;
        string payoutWinString, payoutLossString, payoutDrawString, betAmountWinString, betAmountLossString, betAmountDrawString, restart;

        //Getting the inputs from the user

        Console.WriteLine("Please enter the payout factor in case of a win");
        payoutWinString = Console.ReadLine();
        payoutWin = int.Parse(payoutWinString);

        Console.WriteLine("Please enter the payout factor in case of a loss");
        payoutLossString = Console.ReadLine();
        payoutLoss = int.Parse(payoutLossString);

        Console.WriteLine("Please enter the payout factor in case of a draw");
        payoutDrawString = Console.ReadLine();
        payoutDraw = int.Parse(payoutDrawString);

        Console.WriteLine("Please enter the amount that you wish to bet on a win (in pennies)");
        betAmountWinString = Console.ReadLine();
        betAmountWin = int.Parse(betAmountWinString);

        Console.WriteLine("Please enter the amount that you wish to bet on a loss (in pennies)");
        betAmountLossString = Console.ReadLine();
        betAmountLoss = int.Parse(betAmountLossString);

        Console.WriteLine("Please enter the amount that you wish to bet on a draw (in pennies)");
        betAmountDrawString = Console.ReadLine();
        betAmountDraw = int.Parse(betAmountDrawString);

        //Calc standalone method...

        //...up to here

        //Calculation and output

        grossProfitWin = (payoutWin) * betAmountWin;
        grossProfitLoss = (payoutLoss) * betAmountLoss;
        grossProfitDraw = (payoutDraw) * betAmountDraw;

        netProfitWin = grossProfitWin - betAmountLoss;
        netProfitLoss = grossProfitLoss - betAmountWin;
        netProfitDraw = grossProfitDraw - betAmountDraw;

        if (netProfitWin > 0 & netProfitLoss > 0 & netProfitDraw > 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Profit is guarranteed!");
        }
        else if (netProfitWin < 0 & netProfitLoss < 0 & netProfitDraw > 0)
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
        Console.WriteLine("Profit in case of a win: " + netProfitWin);
        Console.WriteLine("Profit in case of a loss: " + netProfitLoss);
        Console.WriteLine("Profit in case of a draw: " + netProfitDraw);
        Console.WriteLine("\n");
        Console.WriteLine("Enter r to restart");

        restart = Console.ReadLine();
        if (restart == "r")
        {
            Main(null);
        }
    }
}
