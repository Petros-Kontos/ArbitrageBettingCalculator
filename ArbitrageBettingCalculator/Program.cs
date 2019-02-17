using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArbitrageBettingCalculator
{
    
    static float ConvertInput (string input, float inputParse)
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

    static float GetInput (string prompt, string outcome, string input, float inputParse)
    {
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the " + prompt + " " + outcome + ":");
            Console.WriteLine("\n");
            input = Console.ReadLine();
            inputParse = ConvertInput(input, inputParse);
        }
        while (inputParse < 0);

        return inputParse;
    }

    static void Main(string[] args)
    {   
        //Variable declarations, initialisations and assignments.

        float payoutWin, payoutLoss, payoutDraw, betAmountWin, betAmountLoss, betAmountDraw, grossProfitWin, grossProfitLoss, grossProfitDraw, netProfitWin, netProfitLoss, netProfitDraw;
        string payoutWinString, payoutLossString, payoutDrawString, betAmountWinString, betAmountLossString, betAmountDrawString, restart;

        const float DEFAULT_VALUE = 0;
        const string WIN = "win";
        const string LOSS = "loss";
        const string DRAW = "draw";
        const string PAYOUT_PROMPT = "payout factor in case of a";
        const string AMOUNT_PROMPT = "amount that you wish to bet on a";

        payoutWinString = payoutLossString = payoutDrawString = betAmountWinString = betAmountLossString = betAmountDrawString = "";

        payoutWin = payoutLoss = payoutDraw = betAmountWin = betAmountLoss = betAmountDraw = DEFAULT_VALUE;

        //Getting user input

        payoutWin = GetInput(PAYOUT_PROMPT, WIN, payoutWinString, payoutWin);

        payoutLoss = GetInput(PAYOUT_PROMPT, LOSS, payoutLossString, payoutLoss);

        payoutDraw = GetInput(PAYOUT_PROMPT, DRAW, payoutDrawString, payoutDraw);

        betAmountWin = GetInput(AMOUNT_PROMPT, WIN, betAmountWinString, betAmountWin);

        betAmountLoss = GetInput(AMOUNT_PROMPT, LOSS, betAmountLossString, betAmountLoss);

        betAmountDraw = GetInput(AMOUNT_PROMPT, DRAW, betAmountDrawString, betAmountDraw);

        //Numeric Calculations

        grossProfitWin = payoutWin * betAmountWin;
        grossProfitLoss = payoutLoss * betAmountLoss;
        grossProfitDraw = payoutDraw * betAmountDraw;

        netProfitWin = grossProfitWin - betAmountLoss - betAmountDraw;
        netProfitLoss = grossProfitLoss - betAmountWin - betAmountDraw;
        netProfitDraw = grossProfitDraw - betAmountWin - betAmountLoss;

        //Output

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
