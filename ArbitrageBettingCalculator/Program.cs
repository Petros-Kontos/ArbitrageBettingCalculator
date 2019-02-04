using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArbitrageBettingCalculator
{
    
    static float convert (string input, float inputParse)
    {
        const int INVALID = -1;

        try
        {
            inputParse = float.Parse(input);
        }
        catch
        {
            inputParse = INVALID;
            Console.WriteLine("Invalid entry. Please try again.");
        }
        return inputParse;
    }

    static void Main(string[] args)
    {   
        int betAmountWin, betAmountLoss, betAmountDraw;
        float payoutWin, payoutLoss, payoutDraw, grossProfitWin, grossProfitLoss, grossProfitDraw, netProfitWin, netProfitLoss, netProfitDraw;
        string payoutWinString, payoutLossString, payoutDrawString, betAmountWinString, betAmountLossString, betAmountDrawString, restart;

        const int DEFAULT_VALUE = 0;

        payoutWin = payoutLoss = payoutDraw = betAmountWin = betAmountLoss = betAmountDraw = DEFAULT_VALUE;


        //Getting the inputs from the user

        

        {
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter the payout factor in case of a win:");
                Console.WriteLine("\n");
                payoutWinString = Console.ReadLine();
                payoutWin = convert(payoutWinString, payoutWin);
            }
            while (payoutWin < 0);
        }
        /*
        try
        {
            payoutWinString = Console.ReadLine();//this var is not used outside of this block. (That's why it doesn't need to be initialised outside the block.) Should I declare it inside the block??
            payoutWin = float.Parse(payoutWinString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }
        */

        Console.WriteLine("\n");
        Console.WriteLine("Please enter the payout factor in case of a loss");
        Console.WriteLine("\n");
        try
        {
            payoutLossString = Console.ReadLine();
            payoutLoss = float.Parse(payoutLossString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Please enter the payout factor in case of a draw");
        Console.WriteLine("\n");
        try
        {
            payoutDrawString = Console.ReadLine();
            payoutDraw = float.Parse(payoutDrawString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Please enter the amount that you wish to bet on a win (in pence)");
        Console.WriteLine("\n");
        try
        {
            betAmountWinString = Console.ReadLine();
            betAmountWin = int.Parse(betAmountWinString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Please enter the amount that you wish to bet on a loss (in pence)");
        Console.WriteLine("\n");
        try
        {
            betAmountLossString = Console.ReadLine();
            betAmountLoss = int.Parse(betAmountLossString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Please enter the amount that you wish to bet on a draw (in pence)");
        Console.WriteLine("\n");
        try
        {
            betAmountDrawString = Console.ReadLine();
            betAmountDraw = int.Parse(betAmountDrawString);
        }
        catch (Exception e)
        {
            Console.WriteLine("\n");
            Console.WriteLine(e.Message + " A default value of " + DEFAULT_VALUE + " has been used.");
        }

        //Calc standalone method...

        //...up to here

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
