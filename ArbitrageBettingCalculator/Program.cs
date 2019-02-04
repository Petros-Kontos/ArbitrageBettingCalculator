using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArbitrageBettingCalculator
{
    
    static float Convert (string input, float inputParse)
    {
        const int INVALID = -1;

        try
        {
            inputParse = float.Parse(input);
            if (inputParse < 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Negative values are not allowed. Please try again.");
            }
        }
        catch
        {
            inputParse = INVALID;
            Console.WriteLine("\n");
            Console.WriteLine("Invalid entry. Please try again.");
        }
        return inputParse;
    }

    static void Main(string[] args)
    {   
        float payoutWin, payoutLoss, payoutDraw, betAmountWin, betAmountLoss, betAmountDraw, grossProfitWin, grossProfitLoss, grossProfitDraw, netProfitWin, netProfitLoss, netProfitDraw;
        string payoutWinString, payoutLossString, payoutDrawString, betAmountWinString, betAmountLossString, betAmountDrawString, restart;

        const float DEFAULT_VALUE = 0;

        payoutWin = payoutLoss = payoutDraw = betAmountWin = betAmountLoss = betAmountDraw = DEFAULT_VALUE;

        
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the payout factor in case of a win:");
            Console.WriteLine("\n");
            payoutWinString = Console.ReadLine();
            payoutWin = Convert(payoutWinString, payoutWin);
        }
        while (payoutWin < 0);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the payout factor in case of a loss");
            Console.WriteLine("\n");
            payoutLossString = Console.ReadLine();
            payoutLoss = Convert(payoutLossString, payoutLoss);
        }
        while (payoutLoss < 0);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the payout factor in case of a draw");
            Console.WriteLine("\n");
            payoutDrawString = Console.ReadLine();
            payoutDraw = Convert(payoutDrawString, payoutDraw);
        }
        while (payoutDraw < 0);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the amount that you wish to bet on a win");
            Console.WriteLine("\n");
            betAmountWinString = Console.ReadLine();
            betAmountWin = Convert(betAmountWinString, betAmountWin);
        }
        while (betAmountWin < 0);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the amount that you wish to bet on a loss");
            Console.WriteLine("\n");
            betAmountLossString = Console.ReadLine();
            betAmountLoss = Convert(betAmountLossString, betAmountLoss);
        }
        while (betAmountLoss < 0);

        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the amount that you wish to bet on a draw");
            Console.WriteLine("\n");
            betAmountDrawString = Console.ReadLine();
            betAmountDraw = Convert(betAmountDrawString, betAmountDraw);
        }
        while (betAmountDraw < 0);

        //Calculation and output

        grossProfitWin = payoutWin * betAmountWin;
        grossProfitLoss = payoutLoss * betAmountLoss;
        grossProfitDraw = payoutDraw * betAmountDraw;

        netProfitWin = grossProfitWin - betAmountLoss;
        netProfitLoss = grossProfitLoss - betAmountWin;
        netProfitDraw = grossProfitDraw - betAmountDraw;

        if (netProfitWin > 0 & netProfitLoss > 0 & netProfitDraw > 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Profit is guarranteed!");
        }
        else if (netProfitWin <= 0 & netProfitLoss <= 0 & netProfitDraw <= 0)
        {
            Console.WriteLine("\n");
            Console.WriteLine("No profit can be made...");
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
